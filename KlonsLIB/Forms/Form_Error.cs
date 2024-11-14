using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using KlonsLIB.Data;
using KlonsLIB.Misc;

namespace KlonsLIB.Forms
{
    public partial class Form_Error : MyFormBase
    {
        public Form_Error()
        {
            InitializeComponent();
            CheckMyFontSize();
            CheckMyFontAndColors();
        }

        private EPromptType _promptType = EPromptType.None;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public EPromptType PromptType
        {
            get => _promptType;
            set
            {
                _promptType = value;
                cmRollBack.Visible = _promptType == EPromptType.CanRollBack ||
                    _promptType == EPromptType.CanRollBackWithConfirmation;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public EResult DialogResult2 { get; private set; } = EResult.Ok;

        
        static string CheckEOL(string s)
        {
            if (s.IsNOE()) return s;
            s = s.Replace("\n", "\r\n").Replace("\r\r", "\r");
            return s;
        }

        public static EResult ShowException(Form owner, Exception e, EPromptType prompttype = EPromptType.None)
        {
            if (e == null) return EResult.Ok;
            Form_Error fe = new Form_Error();
            fe.tbMsg.Text = CheckEOL(e.Message);
            fe.tbDescr.Text = CheckEOL(e.ToString());
            fe.PromptType = prompttype;
            try
            {
                fe.ShowDialog(owner);
                return fe.DialogResult2;
            }
            catch (Exception) { }
            return EResult.Ok;
        }
        public static void ShowException(Form owner, Exception e, DataGridView dgv)
        {
            MyException e1 = ExceptionHelper.TranslateException(e, dgv);
            ShowException(owner, e1);
        }
        public static void ShowException(Form owner, Exception e, DataTable table)
        {
            MyException e1 = ExceptionHelper.TranslateException(e, table);
            ShowException(owner, e1);
        }
        public static void ShowException(Form owner, Exception e, string newmsg)
        {
            MyException e1 = new MyException(newmsg, e);
            ShowException(owner, e1);
        }
        public static void ShowException(Form owner, Exception e, string newmsg, DataGridView dgv)
        {
            MyException e1 = ExceptionHelper.TranslateException(e, dgv);
            if (!string.IsNullOrEmpty(newmsg))
            {
                e1 = new MyException(newmsg, e1);
            }
            ShowException(owner, e1);
        }
        public static void ShowException(Form owner, Exception e, string newmsg, DataTable table)
        {
            MyException e1 = ExceptionHelper.TranslateException(e, table);
            if (!string.IsNullOrEmpty(newmsg))
            {
                e1 = new MyException(newmsg, e1);
            }
            ShowException(owner, e1);
        }

        public static EResult ShowException(Exception e, EPromptType prompttype = EPromptType.None)
        {
            return ShowException(MyMainForm, e, prompttype);
        }
        public static void ShowException(Exception e, DataGridView dgv)
        {
            ShowException(MyMainForm, e, dgv);
        }
        public static void ShowException(Exception e, DataTable table)
        {
            ShowException(MyMainForm, e, table);
        }
        public static void ShowException(Exception e, MyBindingSource2 bs)
        {
            if (bs == null)
            {
                ShowException(MyMainForm, e);
            }
            else if (bs.UseDataGridView != null)
            {
                ShowException(MyMainForm, e, bs.UseDataGridView);
            }
            else
            {
                var table = bs.GetTable();
                if (bs.UseDataGridView != null)
                {
                    ShowException(MyMainForm, e, table);
                }
                else
                {
                    ShowException(MyMainForm, e);
                }
            }
        }
        public static void ShowException(Exception e, string newmsg)
        {
            ShowException(MyMainForm, e, newmsg);
        }
        public static void ShowException(Exception e, string newmsg, DataGridView dgv)
        {
            ShowException(MyMainForm, e, newmsg, dgv);
        }
        public static void ShowException(Exception e, string newmsg, DataTable table)
        {
            ShowException(MyMainForm, e, newmsg, table);
        }


        private void cmClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            tbDescr.Visible = false;
            Height = tbDescr.Top + (Height - ClientSize.Height);
        }

        private void cmDetails_Click(object sender, EventArgs e)
        {
            if (tbDescr.Visible)
            {
                tbDescr.Visible = false;
                Height = tbDescr.Top + (Height - ClientSize.Height);
            }
            else
            {
                Height = tbDescr.Bottom + 10 + (Height - ClientSize.Height);
                tbDescr.Visible = true;
            }
        }

        private void cmRollBack_Click(object sender, EventArgs e)
        {
            if (PromptType == EPromptType.CanRollBackWithConfirmation)
            {
                var rt = MyMessageBox.Show(
                    "Tiks atceltas izmaiņas visās nesagalabātajās tabulās.\n" +
                    "Vai vēliet turpināt?", "Klons",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, this);
                if (rt != DialogResult.Yes) return;
            }
            DialogResult2 = EResult.RollBack;
            DialogResult = DialogResult.OK;
        }

        public enum EPromptType { None, CanRollBack, WillRollBack, CanRollBackWithConfirmation }
        public enum EResult { Ok, RollBack }

    }
    public class MyException : Exception
    {
        public MyException(string message)
            : base(message)
        {
        }
        public MyException(string message, Exception innerexception)
            : base(message.Zn() + Environment.NewLine, innerexception)
        {
        }
    }

}
