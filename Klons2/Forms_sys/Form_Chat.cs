using KlonsF.Classes;
using KlonsF.ClassesChat;
using KlonsLIB.Misc;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlonsF.Forms_sys
{
    public partial class Form_Chat : MyFormBaseF
    {
        public Form_Chat()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        Font ViewFontBold;
        readonly ChatApi ChatApi = MyData.ChatApi;
        readonly ChatData ChatData = MyData.ChatApi.GetChatData();
        int ChatItemShownCount;

        private void Form_Chat_Load(object sender, EventArgs e)
        {

        }

        private void Form_Chat_Shown(object sender, EventArgs e)
        {
            ViewFontBold = new Font(tbOut.Font, FontStyle.Bold);
            tbUserId.Text = ChatData.UserGuid;
            if (ChatData.ChatItems != null)
            {
                AddChatItemsToView(ChatData.ChatItems);
                ChatItemShownCount = ChatData.ChatItems.Count;
            }
            cbAutoCheckConfig.SelectedIndex = (int)ChatData.ChatCheckInbox;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            panel1.Height = tbUserId.Bottom + tbUserId.Top;
        }

        public void AddChatItemsToView(List<ChatItemData> items)
        {
            foreach (var item in items)
                AddChatItemToView(item);
        }

        public void AddChatItemToView(ChatItemData item)
        {
            var tp = item.Type == EChatItemType.Question ? "jautājums" : "atbilde";
            var s1 = $"{item.DateCreated:dd.MM.yyyy}, {tp}:\r\n";
            var s2 = s1 + item.Content;
            if (!string.IsNullOrEmpty(tbOut.Text))
                tbOut.AppendText("\r\n\r\n");
            int k1 = tbOut.Text?.Length ?? 0;

            tbOut.AppendText(s2);
            tbOut.SelectionStart = k1;

            tbOut.SelectionLength = s2.Length;
            tbOut.SelectionFont = Font;
            tbOut.SelectionIndent = item.Type == EChatItemType.Answer ? 50 : 0;

            tbOut.SelectionLength = s1.Length - 1;
            tbOut.SelectionFont = ViewFontBold;

            tbOut.SelectionLength = 0;
            tbOut.SelectionStart = tbOut.Text.Length;
        }

        void UpdateChatView()
        {
            if (ChatData.ChatItems.Count == ChatItemShownCount) return;
            var new_chatitems = ChatData.ChatItems
                .TakeLast(ChatData.ChatItems.Count - ChatItemShownCount)
                .ToList();
            AddChatItemsToView(new_chatitems);
            ChatItemShownCount = ChatData.ChatItems.Count;
        }

        void SaveChatData()
        {
            ChatData.SaveChat(MyData.ChatDataFileName);
        }

        private async void tsiSend_Click(object sender, EventArgs e)
        {
            var rt = await ChatApi.AddItem(tbIn.Text);
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            tbIn.Text = null;
            if (tbUserId.Text != ChatData.UserGuid)
            {
                tbUserId.Text = ChatData.UserGuid;
            }
            UpdateChatView();
        }

        private async void tsiCheck_Click(object sender, EventArgs e)
        {
            if (ChatData.UserGuid.IsNOE())
            {
                MyMainForm.ShowWarning("Sarakste nav uzsākta.");
                return;
            }
            var rt = await ChatApi.UpdateChat();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            UpdateChatView();
        }

        private async void tsbClear_Click(object sender, EventArgs e)
        {
            if (ChatData.ChatItems.Count == 0)
            {
                MyMainForm.ShowWarning("Sarakste ir tukša.");
                return;
            }
            var rt = await ChatApi.ClearChat();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            tbOut.Clear();
        }

        private void tbUserId_Leave(object sender, EventArgs e)
        {
            var userid = tbUserId.Text;
            if (userid.IsNOE()) return;
            if (ChatData.UserGuid != userid)
            {
                ChatData.UserGuid = userid;
                SaveChatData();
            }
        }

        private void cbAutoCheckConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = cbAutoCheckConfig.SelectedIndex;
            if (k == -1) return;
            var opt = (EChatCheckInbox)k;
            if (ChatData.ChatCheckInbox == opt) return;
            ChatData.ChatCheckInbox = opt;
            SaveChatData();
        }
    }
}
