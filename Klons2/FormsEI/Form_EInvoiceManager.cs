using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataObjectsEI;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using System.ComponentModel;
using UblSharp;
using System.Xml;
using System.Diagnostics;
using KlonsM.Classes;

namespace KlonsM.FormsEI
{
    public partial class Form_EInvoiceManager : MyFormBaseF
    {
        public static Form_EInvoiceManager Instance { get; private set; }

        public Form_EInvoiceManager()
        {
            SetupMenuRenderer();
            InitializeComponent();
            CheckMyFontAndColors();
            MakeGrid();
        }

        string peppol_filename = "PEPPOL-EN16931-UBL.xsl";
        string cen_filename = "CEN-EN16931-UBL.xsl";

        List<InvoiceView> InvoiceList_Full = new();
        BindingList<InvoiceView> InvoiceList_Filtered = new();

        private void MakeGrid()
        {
            sgrInvoice.MakeGrid2();
            sgrInvoice.LinkGrid();
            int h = 0;
            for (int i = 0; i < sgrInvoice.RowsCount; i++)
                h += sgrInvoice.Rows[i].Height;
            mySplitContainer1.SplitterDistance = h + SystemInformation.HorizontalScrollBarHeight + 6;
            sgrInvoice.ClipboardMode = SourceGrid.ClipboardMode.Copy;
            //grDocPVNType.DataCell.View.WordWrap = true;
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyData.SaveSettings();
        }

        string EncryptedEmailPassword = null;

        void UpdateSenderEmailPasswordStatus()
        {
            lbEmailPasswordStatuss.Text = EncryptedEmailPassword.IsNOE() ?
                "parole nav norādīta" : "parole ir saglabāta";
        }

        public void LoadSettingsTab()
        {
            tbSettingsFileFolder.Text = MyData.Params.EInvoiceFolder;
            tbSettingsEmail.Text = MyData.Params.EInvoiceSenderEmail;
            tbSettingsEmailServer.Text = MyData.Params.EInvoiceSenderEmailServer;
            if (MyData.Params.EInvoiceSenderEmailServerPort == 0)
                tbSettingsEmailServerPort.Text = "587";
            else
                tbSettingsEmailServerPort.Text = MyData.Params.EInvoiceSenderEmailServerPort.ToString();
            EncryptedEmailPassword = MyData.Params.EInvoiceSenderEmailPassword;
            UpdateSenderEmailPasswordStatus();
        }

        bool IsSettingsTabChanged()
        {
            if (tbSettingsFileFolder.Text != MyData.Params.EInvoiceFolder) return true;
            if (tbSettingsEmail.Text != MyData.Params.EInvoiceSenderEmail) return true;
            if (!int.TryParse(tbSettingsEmailServerPort.Text, out int port))
            {
                tbSettingsEmailServerPort.Text = "587";
                port = 587;
            }
            if (tbSettingsEmailServer.Text != MyData.Params.EInvoiceSenderEmailServer) return true;
            if (port != MyData.Params.EInvoiceSenderEmailServerPort) return true;
            if (EncryptedEmailPassword != MyData.Params.EInvoiceSenderEmailPassword) return true;
            return false;
        }

        public void ApplySettingsTab()
        {
            if (!IsSettingsTabChanged()) return;
            MyData.Params.EInvoiceFolder = tbSettingsFileFolder.Text;
            MyData.Params.EInvoiceSenderEmail = tbSettingsEmail.Text;
            MyData.Params.EInvoiceSenderEmailServer = tbSettingsEmailServer.Text;
            if (!int.TryParse(tbSettingsEmailServerPort.Text, out int port))
                port = 587;
            MyData.Params.EInvoiceSenderEmailServerPort = port;
            MyData.Params.EInvoiceSenderEmail = tbSettingsEmail.Text;
            MyData.Params.EInvoiceSenderEmailPassword = EncryptedEmailPassword;
            MyData.SaveSettings();
        }

        BindingList<EInvoiceManagerConfig_EMailTemplate> EMailTemplates = new();
        EInvoiceManagerConfig LoadedEInvoiceManagerConfig = null;

        bool IsSenderChanged()
        {
            if ((LoadedEInvoiceManagerConfig?.Templates?.Count ?? 0) == 0) return false;
            if (LoadedEInvoiceManagerConfig.Templates.Count != EMailTemplates.Count) return false;
            for (int i = 0; i < EMailTemplates.Count; i++)
            {
                var t1 = EMailTemplates[i];
                var t2 = LoadedEInvoiceManagerConfig.Templates[i];
                if (t1.Name != t2.Name) return false;
                if (t1.Subject != t2.Subject) return false;
                if (t1.Body != t2.Body) return false;
            }
            return true;
        }

        public void LoadSenderTab()
        {
            var selected_nvoices = InvoiceList_Filtered.Where(x => x.Checked).ToList();
            LoadedEInvoiceManagerConfig = Utils.LoadDataFromXML<EInvoiceManagerConfig>(MyData.EInvoiceManagerConfigFileName);
            if (LoadedEInvoiceManagerConfig == null)
            {
                LoadedEInvoiceManagerConfig = new();
            }
            if (LoadedEInvoiceManagerConfig.Templates == null)
            {
                LoadedEInvoiceManagerConfig.Templates = new();
            }
            if (LoadedEInvoiceManagerConfig.Templates.Count == 0)
            {
                var new_template = new EInvoiceManagerConfig_EMailTemplate()
                {
                    Name = "?",
                    Subject = "?",
                    Body = "?",
                };
                LoadedEInvoiceManagerConfig.Templates.Add(new_template);
            }
            EMailTemplates = new BindingList<EInvoiceManagerConfig_EMailTemplate>(LoadedEInvoiceManagerConfig.Templates);
            bsSenderEmailTemplates.DataSource = EMailTemplates;
        }

        public void SaveSenderTab()
        {
            LoadedEInvoiceManagerConfig.Templates = EMailTemplates.ToList();
            Utils.SaveDataToXML(LoadedEInvoiceManagerConfig, MyData.EInvoiceManagerConfigFileName);
        }

        private void tpSettings_Enter(object sender, EventArgs e)
        {
            LoadSettingsTab();
        }

        private void tpSettings_Leave(object sender, EventArgs e)
        {
            ApplySettingsTab();
        }

        private void tbSettingsFileFolder_ButtonClicked(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog()
            {
                Description = "Norādi mapi priekš e-rēķinu failiem.",
                UseDescriptionForTitle = true,
            };
            var rt = fbd.ShowDialog(this);
            if (rt != DialogResult.OK) return;
            tbSettingsFileFolder.Text = fbd.SelectedPath;
            MyData.Params.EInvoiceFolder = fbd.SelectedPath;
        }

        string CheckFileFolder()
        {
            var folder = MyData.Params.EInvoiceFolder;
            if (folder.IsNOE())
                return "Nav norādīta mape e-rēķinu failiem.";
            if (!Directory.Exists(folder))
                return $"Nav atrasta mape e-rēķinu failiem:/r/n{folder}.";
            var folder_inaākošie = Path.Combine(folder, "Ienākošie");
            var folder_izejošie = Path.Combine(folder, "Izejošie");
            if (!Directory.Exists(folder_inaākošie))
            {
                try
                {
                    Directory.CreateDirectory(folder_inaākošie);
                }
                catch (Exception)
                {
                    return $"Neizdevās izveidot mapi./r/n{folder_inaākošie}.";
                }
            }
            if (!Directory.Exists(folder_izejošie))
            {
                try
                {
                    Directory.CreateDirectory(folder_izejošie);
                }
                catch (Exception)
                {
                    return $"Neizdevās izveidot mapi./r/n{folder_izejošie}.";
                }
            }
            return "Ok";
        }

        void UpdateFolderList()
        {
            var ret = CheckFileFolder();
            if (ret != "Ok")
            {
                MyMainForm.ShowWarning(ret);
                return;
            }
            var folder = MyData.Params.EInvoiceFolder;
            if (!Directory.Exists(folder))
            {
                MyMainForm.ShowWarning($"Mape {folder} nav atrasta.");
                return;
            }
            var subfolders = Directory.GetDirectories(folder)
                .Select(x => Path.GetFileName(x))
                .OrderBy(x => x)
                .ToArray();
            bool haschanged = false;
            if (cbInvoiceFolder.Items.Count != subfolders.Length)
            {
                haschanged = true;
            }
            else
            {
                for (int i = 0; i < subfolders.Length; i++)
                {
                    if ((string)cbInvoiceFolder.Items[i] != subfolders[i])
                    {
                        haschanged = true;
                        break;
                    }
                }
            }
            if (haschanged)
            {
                cbInvoiceFolder.Items.Clear();
                cbInvoiceFolder.Items.AddRange(subfolders);
            }
        }

        private void tpInvoiceList_Enter(object sender, EventArgs e)
        {
            UpdateFolderList();
        }

        private void cbInvoiceFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = cbInvoiceFolder.SelectedIndex;
            if (k == -1) return;
            var ret = CheckFileFolder();
            if (ret != "Ok")
                return;
            var folder = MyData.Params.EInvoiceFolder;
            folder = Path.Combine(folder, cbInvoiceFolder.Text);
            ShowFolder(folder);
        }

        void ShowFolder(string folder)
        {
            tbErrors.Clear();
            tbFilterInvoices.Text = "";
            if (!Directory.Exists(folder)) return;
            var files = Directory.GetFiles(folder, "*.xml");
            var list = new BindingList<InvoiceView>();
            foreach (var file in files)
            {
                ReadInvoice(file, out var invoice);
                UpdateEmail(invoice);
                list.Add(invoice);
            }
            InvoiceList_Filtered = list;
            InvoiceList_Full = InvoiceList_Filtered.ToList();
            bsInvoiceList.DataSource = list;
        }

        InvoiceType LoadInvoice(string filename)
        {
            try
            {
                var xml = File.ReadAllText(filename);
                var ret = UblDocument.Parse<InvoiceType>(xml);
                return ret;
            }
            catch (Exception)
            {
                return null;
            }
        }

        string ValidateInvoice(string filename)
        {
            var data_dir = Utils.GetMyFolder();
            var p_fnm = Path.Combine(data_dir, peppol_filename);
            var c_fnm = Path.Combine(data_dir, cen_filename);
            var errors = EInvoiceLib.EInvoiceValidator.ValidateUbiDocument2(filename, p_fnm, c_fnm);
            if (errors.Count == 0)
            {
                return "Ok";
            }
            var fnm = Path.GetFileName(filename);
            var folder = Path.GetFileName(Path.GetDirectoryName(filename));
            var ret = errors
                .Select(x => x.Message)
                .Aggregate((x1, x2) => x1 + "\r\n" + x2);

            return ret;
        }

        bool ReadInvoice(string filename, out InvoiceView invoice)
        {
            var fnmwitountext = Path.GetFileNameWithoutExtension(filename);
            var folder1 = Path.GetDirectoryName(filename);
            var document_extension = Directory.GetFiles(folder1, $"{fnmwitountext}.*")
                .Select(x => Path.GetExtension(x)?.ToLower())
                .Where(x => x != ".xml")
                .FirstOrDefault();
            invoice = new InvoiceView()
            {
                FullFileName = filename,
                SubFolderName = Path.GetFileName(Path.GetDirectoryName(filename)),
                InvoiceDocumentExtension = document_extension
            };
            var err = ValidateInvoice(filename);
            if (err != "Ok")
            {

                var fnm = Path.GetFileName(filename);
                var folder = Path.GetFileName(Path.GetDirectoryName(filename));
                var err2 = $"Fails:{folder}\\{fnm}\r\n{err}";
                invoice.ValidationMessage = err;
                AddFileError(fnm, folder, invoice.ValidationMessage);
                return false;
            }
            InvoiceType invoicetype = LoadInvoice(filename);
            if (invoicetype == null)
            {
                invoice.ValidationMessage = "Neizdevās nolasīt rēķina datus no faila.";
                AddFileError(invoice.FileName, invoice.SubFolderName, invoice.ValidationMessage);
                return false;
            }
            try
            {
                invoice.ReadFrom(invoicetype);
                invoice.ValidationMessage = "Ok";
                return true;
            }
            catch (Exception)
            {
                invoice.ValidationMessage = "Neizdevās nolasīt rēķina datus no faila.";
                AddFileError(invoice.FileName, invoice.SubFolderName, invoice.ValidationMessage);
                return false;
            }
        }

        public bool UpdateEmail(InvoiceView invoice)
        {
            var myregnr = MyData.Params.CompRegNr;
            var supplierregnr = invoice.SupplierID;
            var customerregnr = invoice.CustomerID;
            if (myregnr.IsNOE() || customerregnr.IsNOE() || supplierregnr.IsNOE())
                return false;
            string partnerregnr = null;
            if (myregnr == supplierregnr) partnerregnr = customerregnr;
            if (myregnr == customerregnr) partnerregnr = supplierregnr;
            if (partnerregnr == null) return false;
            var stores = MyData.DataSetKlonsM.M_STORES.Where(x => x.REGNR == partnerregnr).ToList();
            var email = stores.Select(x => x.EMAIL).Where(x => !x.IsNOE()).FirstOrDefault();
            if (email.IsNOE()) return false;
            invoice.Email = email;
            return true;
        }

        void AddFileError(string filename, string foldername, string error)
        {
            var msg = $"Fails: {foldername}\\{filename}\r\n{error}\r\n\r\n";
            tbErrors.AppendText(msg);
        }

        void AddError(string error)
        {
            tbErrors.AppendText(error + "\r\n\r\n");
        }


        void CheckEmptyElements(XmlNode node)
        {
            if (node.ChildNodes.Count == 0 && string.IsNullOrWhiteSpace(node.InnerText))
                Debug.WriteLine("Empty element: " + node.Name);
            foreach (XmlNode childNode in node.ChildNodes)
                CheckEmptyElements(childNode);
        }

        private void CheckEmptyElements(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            CheckEmptyElements(doc.DocumentElement);
        }

        void OpenFolderInExplorer(string folder)
        {
            try { Process.Start("explorer.exe", folder); } catch (Exception) { }
        }

        void SelectInvoicesNone()
        {
            if (InvoiceList_Filtered == null || InvoiceList_Filtered.Count == 0) return;
            foreach (var invoice in InvoiceList_Filtered)
            {
                invoice.Checked = false;
            }
        }

        void SelectInvoicesAll()
        {
            if (InvoiceList_Filtered == null || InvoiceList_Filtered.Count == 0) return;
            foreach (var invoice in InvoiceList_Filtered)
            {
                invoice.Checked = true;
            }
        }

        bool ValidateInvices(List<InvoiceView> invoices)
        {
            tbErrors.Clear();
            bool haserrors = false;
            foreach (var invoice in invoices)
            {
                var err = ReadInvoice(invoice.FullFileName, out var updated_invoice);
                invoice.ReadFrom(updated_invoice);
                UpdateEmail(invoice);
                if (!err)
                {
                    haserrors = true;
                }
            }
            if (haserrors)
            {
                tcTabs.SelectedTab = tpErrors;
                return false;
            }
            else
            {
                MyMainForm.ShowInfo("Rēķini tika pārbaudīts, kļūdas netika atrastas.");
                return true;
            }
        }

        void MoveSelectedToFolder(string base_foldername, string src_foldername,
            string dest_foldername, List<InvoiceView> invoicelist)
        {
            if (invoicelist.Count == 0) return;
            var moved = new List<InvoiceView>();
            var dest_foldername_full = Path.Combine(base_foldername, dest_foldername);
            foreach (var invoice in invoicelist)
            {
                try
                {
                    var dstfnm = Path.Combine(dest_foldername_full, Path.GetFileName(invoice.FullFileName));
                    File.Move(invoice.FullFileName, dstfnm);
                    if (invoice.InvoiceDocumentExtension.IsNOE())
                    {
                        moved.Add(invoice);
                    }
                    else
                    {
                        var srcfnm2 = Path.Combine(
                            Path.GetDirectoryName(invoice.FullFileName),
                            Path.GetFileNameWithoutExtension(invoice.FullFileName) +
                                invoice.InvoiceDocumentExtension);
                        var dstfnm2 = Path.Combine(dest_foldername_full,
                            Path.GetFileNameWithoutExtension(invoice.FullFileName) +
                                invoice.InvoiceDocumentExtension);
                        try
                        {
                            File.Move(srcfnm2, dstfnm2);
                            moved.Add(invoice);
                        }
                        catch
                        {
                            File.Move(dstfnm, invoice.FullFileName);
                        }
                    }
                }
                catch (Exception)
                { }
            }
            foreach (var invoice in moved)
            {
                InvoiceList_Filtered.Remove(invoice);
                InvoiceList_Full.Remove(invoice);
            }
            var msg = $"{moved.Count} no {invoicelist.Count} faili pārvietoti no [{src_foldername}] uz [{dest_foldername}]";
            MyMainForm.ShowInfo(msg, owner: this);
        }

        void MoveSelectedInvices()
        {
            dgvInvoiceList.EndEdit();
            if (bsInvoiceList.Count == 0)
            {
                MyMainForm.ShowWarning("Rēķinu saraksts ir tukšs.");
                return;
            }
            if (cbInvoiceFolder.SelectedIndex == -1)
            {
                MyMainForm.ShowWarning("Nav failu mape.");
                return;
            }
            var selected_invoices = InvoiceList_Filtered.Where(x => x.Checked).ToList();
            if (selected_invoices.Count == 0)
            {
                MyMainForm.ShowWarning("Neviens rēķins nav atzīmēts.");
                return;
            }
            var currentfolder = cbInvoiceFolder.Text;
            var foldernames = cbInvoiceFolder.Items.Cast<string>().ToArray();
            var dest_foldername = Form_SelectFolder.SelectFolder(currentfolder, foldernames, selected_invoices.Count);
            if (dest_foldername == null) return;
            var src_foldername = cbInvoiceFolder.Text;
            var base_foldername = MyData.Params.EInvoiceFolder;
            MoveSelectedToFolder(base_foldername, src_foldername, dest_foldername, selected_invoices);
        }

        void OpenInExplorerSelectedFolder()
        {
            int k = cbInvoiceFolder.SelectedIndex;
            if (k == -1) return;
            var ret = CheckFileFolder();
            if (ret != "Ok")
                return;
            var folder = MyData.Params.EInvoiceFolder;
            folder = Path.Combine(folder, cbInvoiceFolder.Text);
            OpenFolderInExplorer(folder);
        }

        bool ValidateSelected()
        {
            dgvInvoiceList.EndEdit();
            tbErrors.Clear();
            if (bsInvoiceList.Count == 0)
            {
                MyMainForm.ShowWarning("Rēķinu saraksts ir tukšs.");
                return false;
            }
            var selected_invoices = InvoiceList_Filtered.Where(x => x.Checked).ToList();
            if (selected_invoices.Count == 0)
            {
                MyMainForm.ShowWarning("Neviens rēķins nav atzīmēts.");
                return false;
            }
            bool haserrors = ValidateInvices(selected_invoices);
            return haserrors;
        }

        bool ValidateAll()
        {
            tbErrors.Clear();
            if (bsInvoiceList.Count == 0)
            {
                MyMainForm.ShowWarning("Rēķinu saraksts ir tukšs.");
                return false;
            }
            var all_invoices = InvoiceList_Filtered.ToList();
            bool haserrors = ValidateInvices(all_invoices);
            return haserrors;
        }

        bool ValidateCurrent()
        {
            dgvInvoiceList.EndEdit();
            tbErrors.Clear();
            var invoice = bsInvoiceList.Current as InvoiceView;
            if (invoice == null)
            {
                MyMainForm.ShowWarning("Sarakstā nav rēķinu.");
                return false;
            }
            bool haserrors = ValidateInvices([invoice]);
            return haserrors;
        }

        void ShowRealInvoice()
        {
            dgvInvoiceList.EndEdit();
            tbErrors.Clear();
            var invoice = bsInvoiceList.Current as InvoiceView;
            if (invoice == null)
            {
                MyMainForm.ShowWarning("Sarakstā nav rēķinu.");
                return;
            }
            if (invoice.InvoiceDocumentExtension.IsNOE())
            {
                MyMainForm.ShowWarning("e=Rēķinam nav pievienots pilnais rēķins, vai tas nav atrasts.");
                return;
            }

            var fnm = Path.GetFileNameWithoutExtension(invoice.FullFileName) + invoice.InvoiceDocumentExtension;
            var fnm2 = Path.Combine(Path.GetDirectoryName(invoice.FullFileName), fnm);
            if (!File.Exists(fnm2))
            {
                MyMainForm.ShowWarning($"e=Rēķina pilnā rēķina fails [{fnm}] netika atrasts.");
                return;
            }
            try
            {
                Process.Start(new ProcessStartInfo(fnm2) { UseShellExecute = true });
            }
            catch { }
        }

        public void FilterInvoiceList(string filter)
        {
            if (filter.IsNOE())
            {
                InvoiceList_Filtered = new(InvoiceList_Full);
                bsInvoiceList.DataSource = InvoiceList_Filtered;
                return;
            }
            BindingList<InvoiceView> new_list = new();
            foreach (var invoice in InvoiceList_Full)
            {
                if (invoice.IssueDate != null && invoice.IssueDate.Value.ToString("dd.MM.yyyy").Contains(filter))
                {
                    new_list.Add(invoice);
                }
                else if (invoice.SupplierName.Nz().Contains(filter))
                {
                    new_list.Add(invoice);
                }
                else if (invoice.CustomerName.Nz().Contains(filter))
                {
                    new_list.Add(invoice);
                }
                else if (invoice.SupplierID.Nz().Contains(filter))
                {
                    new_list.Add(invoice);
                }
                else if (invoice.CustomerID.Nz().Contains(filter))
                {
                    new_list.Add(invoice);
                }
                else if (invoice.ID.Nz().Contains(filter))
                {
                    new_list.Add(invoice);
                }
            }
            InvoiceList_Filtered = new_list;
            bsInvoiceList.DataSource = new_list;
        }

        void ChangeEmailPassword()
        {
            var frm = new Form_SetEmailPassword();
            var rt = frm.ShowDialog(this);
            if (rt != DialogResult.OK) return;
            var psw_real = frm.RealPassword;
            var psw_weak = frm.WeakPassword;
            EncryptedEmailPassword = PasswordCrypt.EncryptStrongPassword(psw_weak, psw_real);
            UpdateSenderEmailPasswordStatus();
        }

        string GetSenderEmailPassword()
        {
            var weak_psw = tbSenderEmailPassword.Text;
            var encrypted_psw = MyData.Params.EInvoiceSenderEmailPassword;
            if (weak_psw.IsNOE())
            {
                MyMainForm.ShowWarning("Jānorāda e-pasta parole.");
                return null;
            }
            if (encrypted_psw.IsNOE())
            {
                MyMainForm.ShowWarning("Iestatijumos nav norādīta faktiskā e-pasta parole.");
                return null;
            }
            try
            {
                var real_psw = PasswordCrypt.DecryptStrongPassword(weak_psw, encrypted_psw);
                return real_psw;
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Paroles dešifrēšana neizdevās, iespējams nav norādīta pareiza parole.");
                return null;
            }
        }

        void SendEmails()
        {
            var selected_invoices = InvoiceList_Filtered.Where(x => x.Checked).ToList();
            if (selected_invoices.Count == 0)
            {
                MyMainForm.ShowWarning("Neviens rēķins nav atzīmēts.");
                return;
            }
            var email = MyData.Params.EInvoiceSenderEmail;
            var emaiserver = MyData.Params.EInvoiceSenderEmailServer;
            var emaiserverport = MyData.Params.EInvoiceSenderEmailServerPort;
            if (email.IsNOE())
            {
                MyMainForm.ShowWarning("Nav norādīts e-pasts.");
                return;
            }
            var real_psw = GetSenderEmailPassword();
            if (real_psw == null) return;
            if (emaiserver.IsNOE() || emaiserverport == 0)
            {
                MyMainForm.ShowWarning("Nav norādīti e-pasta servera dati.");
                return;
            }
            if (bsSenderEmailTemplates.Count == 0 || bsSenderEmailTemplates.Current == null)
            {
                MyMainForm.ShowWarning("Nav norādīta e-pasta sagatave.");
                return;
            }
            var template = bsSenderEmailTemplates.Current as EInvoiceManagerConfig_EMailTemplate;
            var ct_notvalid = selected_invoices.Where(x => x.ValidationMessage != "Ok").Count();
            if (ct_notvalid > 0)
            {
                MyMainForm.ShowWarning($"{ct_notvalid} rēķinos ir atrastas ķļūdas.");
                return;
            }
            var ct_noemail = selected_invoices.Where(x => x.Email.IsNOE()).Count();
            if (ct_noemail > 0)
            {
                MyMainForm.ShowWarning($"{ct_noemail} rēķiniem nav norādīta saņēmēja e-pasta adrese.");
                return;
            }
            var ct_norealinvoice = selected_invoices.Where(x => x.InvoiceDocumentExtension.IsNOE()).Count();
            if (ct_norealinvoice > 0)
            {
                MyMainForm.ShowWarning($"{ct_norealinvoice} rēķiniem nav pievienots pilnais rēķins.");
                return;
            }
            Form_SendingEmails.SendEmails(selected_invoices, email, real_psw,
                emaiserver, emaiserverport, template, out var sentemails);
        }

        private void bsInvoiceList_CurrentChanged(object sender, EventArgs e)
        {
            var invoice = bsInvoiceList.Current as InvoiceView;
            if (invoice == null)
            {
                bsInvoiceLines.DataSource = new BindingList<InvoiceLine>();
                return;
            }
            bsInvoiceLines.DataSource = invoice.InvoiceLines;
        }

        private void tsbShowInvoice_Click(object sender, EventArgs e)
        {
            var invoice = bsInvoiceList.Current as InvoiceView;
            if (invoice == null)
            {
                return;
            }
            tcTabs.SelectedTab = tpInvoice;
        }

        private void tsbSelectNoneInvoice_Click(object sender, EventArgs e)
        {
            SelectInvoicesNone();
        }

        private void tsbSelectAllInvoices_Click(object sender, EventArgs e)
        {
            SelectInvoicesAll();
        }

        private void tsbValidateSelected_Click(object sender, EventArgs e)
        {
            ValidateSelected();
        }

        private void tsbValidateAll_Click(object sender, EventArgs e)
        {
            ValidateAll();
        }

        private void tsbValidateCurrent_Click(object sender, EventArgs e)
        {
            ValidateCurrent();
        }

        private void tsbMoveSelectedInvices_Click(object sender, EventArgs e)
        {
            MoveSelectedInvices();
        }

        private void btShowFolder_Click(object sender, EventArgs e)
        {
            OpenInExplorerSelectedFolder();
        }

        private void tbFilterInvoices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                FilterInvoiceList(tbFilterInvoices.Text);
            }
            if (e.KeyCode == Keys.Escape)
            {
                tbFilterInvoices.Text = null;
                FilterInvoiceList(null);
            }
        }

        private void tsbShowRealInvoice_Click(object sender, EventArgs e)
        {
            ShowRealInvoice();
        }

        private void cmSetEmailPassword_Click(object sender, EventArgs e)
        {
            ChangeEmailPassword();
        }

        private void tpSendPerEmail_Enter(object sender, EventArgs e)
        {
            var selected_nvoices = InvoiceList_Filtered.Where(x => x.Checked).ToList();
            lbSendEmailInfo.Text = $"Sūtīšanai tiek sagatavoti {selected_nvoices.Count} e-rēķini.";
            tbSenderEmail.Text = MyData.Params.EInvoiceSenderEmail;
            if (LoadedEInvoiceManagerConfig == null)
                LoadSenderTab();
        }

        private void tpSendPerEmail_Leave(object sender, EventArgs e)
        {
            if (!IsSenderChanged()) return;
            SaveSenderTab();
        }

        private void tsbNewEmailTemplate_Click(object sender, EventArgs e)
        {
            cbSenderEmailTemplates.Focus();
            var frm = new Form_InputBox("", "Jaunās e-pasta sagataves nosaukumu.", "?");
            var rt = frm.ShowDialog(this);
            if (rt != DialogResult.OK) return;
            var name = frm.SelectedValue;
            if (name.IsNOE()) return;
            var new_template = new EInvoiceManagerConfig_EMailTemplate()
            {
                Name = name,
                Subject = "?",
                Body = "?",
            };
            EMailTemplates.Add(new_template);
            bsSenderEmailTemplates.Position = EMailTemplates.Count - 1;
        }

        private void tsbDeleteEmailTemplate_Click(object sender, EventArgs e)
        {
            if (EMailTemplates.Count < 2) return;
            if (bsSenderEmailTemplates.Current == null) return;
            EMailTemplates.RemoveAt(bsSenderEmailTemplates.Position);
        }

        private void tsbSenderEditTemplateName_Click(object sender, EventArgs e)
        {
            cbSenderEmailTemplates.Focus();
            if (EMailTemplates.Count == 0) return;
            if (bsSenderEmailTemplates.Current == null) return;
            var current = bsSenderEmailTemplates.Current as EInvoiceManagerConfig_EMailTemplate;
            var frm = new Form_InputBox("", "Jauns e-pasta sagataves nosaukums.", current.Name);
            var rt = frm.ShowDialog(this);
            if (rt != DialogResult.OK) return;
            var name = frm.SelectedValue;
            if (name.IsNOE()) return;
            current.Name = name;
            var pos = bsSenderEmailTemplates.Position;
            cbSenderEmailTemplates.DataSource = null;
            cbSenderEmailTemplates.DataSource = bsSenderEmailTemplates;
            cbSenderEmailTemplates.DisplayMember = "Name";
        }

        private void cmSendEmail_Click(object sender, EventArgs e)
        {
            SendEmails();
        }

        private void tbSettingsEmail_Leave(object sender, EventArgs e)
        {
            var email = tbSettingsEmail.Text;
            if (email.IsNOE()) return;
            if (email == MyData.Params.EInvoiceSenderEmail) return;
            if (email.ToLower().EndsWith("gmail.com"))
            {
                tbSettingsEmailServer.Text = "smtp.gmail.com";
                tbSettingsEmailServerPort.Text = "587";
            }
            else
            if (email.ToLower().EndsWith("inbox.lv"))
            {
                tbSettingsEmailServer.Text = "mail.inbox.lv";
                tbSettingsEmailServerPort.Text = "465";
            }
        }


        void EmailBodyInsertText(string text)
        {
            var pos = tbSenderEmailBody.SelectionStart;
            var txt = tbSenderEmailBody.Text.Insert(pos, text);
            tbSenderEmailBody.Text = txt;
            tbSenderEmailBody.SelectionStart = pos + text.Length;
        }
        void EmailSubjectInsertText(string text)
        {
            var pos = tbSenderEmailSubject.SelectionStart;
            var txt = tbSenderEmailSubject.Text.Insert(pos, text);
            tbSenderEmailSubject.Text = txt;
            tbSenderEmailSubject.SelectionStart = pos + text.Length;
        }
        void EmailTemplateInsertText(string text)
        {
            if (ActiveControl == tbSenderEmailSubject)
                EmailSubjectInsertText(text);
            else
                EmailBodyInsertText(text);
        }

        public static string TagSenderName = "{SūtītājaNosaukums}";
        public static string TagReceiverName = "{SaņēmējaNosaukums}";
        public static string TagInvoiceID = "{RēķinaNumurs}";

        private void tsbTemplateCodeSenderName_Click(object sender, EventArgs e)
        {
            EmailTemplateInsertText(TagSenderName);
        }

        private void tsbTemplateCodeReceiverName_Click(object sender, EventArgs e)
        {
            EmailTemplateInsertText(TagReceiverName);
        }

        private void tsbTemplateCodeInvoiceId_Click(object sender, EventArgs e)
        {
            EmailTemplateInsertText(TagInvoiceID);
        }
    }
}
