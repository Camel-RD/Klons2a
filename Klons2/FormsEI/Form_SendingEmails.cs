using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjectsEI;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using KlonsM.Classes;

namespace KlonsM.FormsEI
{
    public partial class Form_SendingEmails : MyFormBaseF
    {
        public Form_SendingEmails()
        {
            SetupMenuRenderer();
            InitializeComponent();
            CheckMyFontAndColors();
            dgcStatus.ColorMarkNeeded += DgcStatus_ColorMarkNeeded;
        }

        private void DgcStatus_ColorMarkNeeded(object sender, KlonsLIB.Components.DataGridViewColorMarkColumnEventArgs e)
        {
            e.MarkColor = Color.LightYellow;
            if (e.RowNr == dgvSendingEmailsList.NewRowIndex) return;
            var item = bsSendingEmailsList[e.RowNr] as EmailSenderItem;
            if (item == null) return;
            if (item.Status.IsNOE()) return;
            if (item.Status == StatusSending)
                e.MarkColor = Color.LightBlue;
            else if (item.Status == StatusSent)
                e.MarkColor = Color.LightGreen;
            else if (item.Status == StatusError)
                e.MarkColor = Color.Pink;
        }

        public bool Sending = false;
        public bool CancelRequested = false;

        private void Form_SendingEmails_Load(object sender, EventArgs e)
        {

        }

        public List<EmailSenderItem> EmailSenderItem = new();
        public List<InvoiceView> Invoices = new();
        public List<InvoiceView> SentInvoices = new();
        public EInvoiceManagerConfig_EMailTemplate Template;
        public string SenderEmail;
        public string SenderEmailPassword;
        public string SenderEmailServer;
        public int SenderEmailServerPort;


        public static void SendEmails(List<InvoiceView> invoices,
            string senderemail,
            string senderemailpassword,
            string senderemailserver,
            int senderemailserverport,
            EInvoiceManagerConfig_EMailTemplate template,
            out List<InvoiceView> sentinvoices)
        {
            sentinvoices = null;
            var frm = new Form_SendingEmails();
            frm.SenderEmail = senderemail;
            frm.SenderEmailPassword = senderemailpassword;
            frm.SenderEmailServer = senderemailserver;
            frm.SenderEmailServerPort = senderemailserverport;
            frm.Template = template;
            frm.Invoices = invoices;
            frm.EmailSenderItem = invoices.Select(x => new EmailSenderItem()
            {
                CustomerName = x.CustomerName,
                InvoiceID = x.ID,
                CustomerEmail = x.Email,
                Status = "?"
            }).ToList();
            frm.bsSendingEmailsList.DataSource = frm.EmailSenderItem;
            frm.ShowDialog();
        }

        async Task<string> SendEmailWithAttachment(
                string recipientEmail,
                string subject,
                string body,
                string[] attachmentPaths,
                CancellationToken token)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SenderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;

                foreach (var attachmentPath in attachmentPaths)
                {
                    Attachment attachment = new Attachment(attachmentPath);
                    mail.Attachments.Add(attachment);
                }

                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(SenderEmailServer, SenderEmailServerPort))
                {
                    smtp.Credentials = new NetworkCredential(SenderEmail, SenderEmailPassword);
                    smtp.EnableSsl = true;
                    //await Task.Delay(3000, token);
                    await smtp.SendMailAsync(mail, token);
                    return "Ok";
                }
            }
            catch (TaskCanceledException ex)
            {
                return "E-pasta sūtīšana tika atcelta.";
            }
            catch (SmtpFailedRecipientException ex)
            {
                return "Saņēmēja e-pasta adreses kļūda.";
            }
            catch (SmtpException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        CancellationTokenSource CTS = null;

        string StatusSending = "tiek sūtīts";
        string StatusSent = "nosūtīts";
        string StatusError = "kļūda";

        public async Task<bool> SendEmails()
        {
            tsbSendingClose.Visible = false;
            tsbSendingCancel.Visible = true;
            CTS = new CancellationTokenSource();
            for (int i = 0; i < Invoices.Count; i++)
            {
                if (CTS.IsCancellationRequested || CancelRequested)
                {
                    tsbSendingClose.Visible = true;
                    tsbSendingCancel.Visible = false;
                    return false;
                }
                var invoice = Invoices[i];
                var listitem = EmailSenderItem[i];
                listitem.Status = StatusSending;
                dgvSendingEmailsList.InvalidateCell(dgcStatus.Index, i);
                var fullinvoicefnm = invoice.InvoiceDocumentFullFilename;
                string[] attachmentfilenames =
                    fullinvoicefnm == null ?
                    [invoice.FullFileName] :
                    [invoice.FullFileName, fullinvoicefnm];
                var subject = PrepareEmailText(Template.Subject, invoice);
                var body = PrepareEmailText(Template.Body, invoice);
                var ret = await SendEmailWithAttachment(invoice.Email,
                    subject, body, attachmentfilenames, CTS.Token);
                if (ret == "Ok")
                {
                    listitem.Status = StatusSent;
                    dgvSendingEmailsList.InvalidateCell(dgcStatus.Index, i);
                    SentInvoices.Add(invoice);
                    continue;
                }
                listitem.Status = StatusError;
                dgvSendingEmailsList.InvalidateCell(dgcStatus.Index, i);
                var err = $"{invoice.FileName}, {invoice.CustomerName}, {invoice.ID}\r\n";
                err += ret + "\r\n\r\n";
                tbSendingEmailsErrors.AppendText(err);
                if (ret.StartsWith("The SMTP server requires a secure connection or the client was not authenticated"))
                {
                    MyMainForm.ShowWarning("E-pasta Autentifikācijas kļūda, iespējam nepareiza parole.");
                    tsbSendingClose.Visible = true;
                    tsbSendingCancel.Visible = false;
                    return false;
                }
            }
            var msg = $"{SentInvoices.Count} no {Invoices.Count} rēķini tika nosūtīti.";
            if (Invoices.Count == SentInvoices.Count)
            {
                MyMainForm.ShowInfo(msg, owner: this);
            }
            else
            {
                MyMainForm.ShowWarning(msg, owner: this);
            }
            tsbSendingClose.Visible = true;
            tsbSendingCancel.Visible = false;
            return true;
        }

        string PrepareEmailText(string text, InvoiceView invoice)
        {
            var myname = MyData.Params.CompName;
            var customername = invoice.CustomerName;
            var invoiceid = invoice.ID;
            var ret = text.Replace(Form_EInvoiceManager.TagSenderName, myname);
            ret = ret.Replace(Form_EInvoiceManager.TagReceiverName, customername);
            ret = ret.Replace(Form_EInvoiceManager.TagInvoiceID, invoiceid);
            return ret;
        }

        private async void Form_SendingEmails_Shown(object sender, EventArgs e)
        {
            await SendEmails();
        }

        private void tsbSendingCancel_Click(object sender, EventArgs e)
        {
            if (CTS == null) return;
            try
            {
                CancelRequested = true;
                CTS.Cancel();
                tsbSendingCancel.Visible = false;
            }
            catch { }
        }

        private void tsbSendingClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
