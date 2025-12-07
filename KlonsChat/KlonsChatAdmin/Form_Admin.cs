using KlonsChatAdmin;
using KlonsChatAdmin.classes;
using KlonsChatDto.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace KlonsChatAdmin
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: false, reloadOnChange: true)
                .Build();
            tbSupportId.Text = AdminGuid = _configuration.GetSection("AdminGuid").Value;
            ServerUrl = app.Default.serverurl;
            InitRefit();
            Chat = Chat.LoadChat(ChatFileName);
            if (Chat != null)
            {
                tbUserId2.Text = Chat.UserGuid;
            }
        }

        void InitRefit()
        {
            KlonsqApi = KlonsChatApiClientFactory.Create(ServerUrl);
        }

        private readonly IConfiguration _configuration;
        //string serverurl = "https://zbks.eu:5063";
        string ServerUrl = "http://localhost:5292";
        const string ChatFileName = "Chat.xml";
        Font ViewFontBold;
        IklonsqApi KlonsqApi;
        string Token;
        HubConnection Connection;
        string AdminGuid;
        Chat Chat = null;


        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Form_Admin_Shown(object sender, EventArgs e)
        {
            ViewFontBold = new Font(tbOut.Font, FontStyle.Bold);
            AddChatItemsToView(EChatView.TestUser, Chat.ChatItems);
        }


        public enum EChatView { Admin, TestUser }
        public void AddChatItemsToView(EChatView view, List<ChatItem> items)
        {
            foreach (var item in items)
                AddChatItemToView(view, item);
        }

        public void AddChatItemToView(EChatView view, ChatItem item)
        {
            var tb_view = view == EChatView.Admin ? tbOut : tbOut2;
            var tp = item.Type == EChatItemType.Question ? "jautājums" : "atbilde";
            var s1 = $"{item.DateCreated:dd.MM.yyyy}, {tp}:\r\n";
            var s2 = s1 + item.Content;
            if (!string.IsNullOrEmpty(tb_view.Text))
                tb_view.AppendText("\r\n\r\n");
            int k1 = tb_view.Text?.Length ?? 0;

            tb_view.AppendText(s2);
            tb_view.SelectionStart = k1;

            tb_view.SelectionLength = s2.Length;
            tb_view.SelectionFont = Font;
            tb_view.SelectionIndent = item.Type == EChatItemType.Answer ? 50 : 0;

            tb_view.SelectionLength = s1.Length - 1;
            tb_view.SelectionFont = ViewFontBold;

            tb_view.SelectionLength = 0;
            tb_view.SelectionStart = tb_view.Text.Length;

            //var color = item.Type == EChatItemType.Question ? Color.CadetBlue : tbOut.ForeColor;
            //tbOut.SelectionColor = color;
        }

        void AddSignalText(string text)
        {
            Invoke(() => tbSignals.AppendText(text + "\r\n"));
        }

        void AddSignalText(string text, Color color)
        {
            Invoke(() =>
            {
                int k = tbSignals.Text.Length;
                tbSignals.AppendText(text + "\r\n");
                tbSignals.SelectionStart = k;
                tbSignals.SelectionLength = tbSignals.Text.Length - k;
                tbSignals.SelectionColor = color;
                tbSignals.SelectionLength = 0;
                tbSignals.SelectionStart = tbSignals.Text.Length;
                tbSignals.SelectionColor = tbSignals.ForeColor;
            });
        }

        public async Task<string> AddItem()
        {
            var content = tbIn.Text?.Trim();
            if (string.IsNullOrEmpty(content))
                return "Chat message not provided.";

            var userid = tbUserId.Text;
            var supportid = tbSupportId.Text;
            if (string.IsNullOrEmpty(userid))
                return "User id not provided.";
            if (string.IsNullOrEmpty(supportid))
                return "Support id not provided.";
            var req = new AddItemRequest()
            {
                Content = content,
                UserGuid = tbUserId.Text,
                SupportGuid = tbSupportId.Text
            };
            var ret = await KlonsqApi.AddItem(req);
            if (!ret.IsSuccessful || ret.Content.Result == EAddItemsResult.BadRequest ||
                ret.Content.Item?.Content == null)
            {
                return "Server request failed.";
            }
            var addeditem = ret.Content.Item;
            var new_item = new ChatItem()
            {
                Id = addeditem.Id,
                Content = addeditem.Content,
                DateCreated = addeditem.DateCreated,
                Type = addeditem.Type == EItemDtoType.Answer ? EChatItemType.Answer : EChatItemType.Question
            };
            AddChatItemsToView(EChatView.Admin, [new_item]);
            return "OK";
        }

        public async Task<string> GetChat()
        {
            var userid = tbUserId.Text;
            var supportid = tbSupportId.Text;
            if (string.IsNullOrEmpty(userid))
                return "User id not provided.";
            if (string.IsNullOrEmpty(supportid))
                return "Support id not provided.";
            var ret = await KlonsqApi.GetItems(userid, -1);
            if (!ret.IsSuccessful || ret.Content.Result == EGetItemsResult.None)
            {
                return "Server request failed.";
            }
            if (ret.Content.Items != null && ret.Content.Items.Count > 0)
            {
                var nuewitems = Chat.Map(ret.Content.Items);
                tbOut.Text = "";
                AddChatItemsToView(EChatView.Admin, nuewitems);
            }
            return "OK";
        }

        public async Task<string> ClearChat()
        {
            var userid = tbUserId.Text;
            if (string.IsNullOrEmpty(userid))
                return "User id not provided.";
            var ret = await KlonsqApi.ClearChat(userid);
            if (!ret.IsSuccessful || ret.Content.Result == EClearChatResult.None)
            {
                return "Server request failed.";
            }
            tbOut.Text = "";
            return "OK";
        }

        public async Task<string> GetUpdatedChats()
        {
            var supportid = tbSupportId.Text;
            if (string.IsNullOrEmpty(supportid))
                return "Support id not provided.";
            var ret = await KlonsqApi.GetUpdatedChats(supportid);
            if (!ret.IsSuccessful || ret.Content.Result == EGetUpdatedChatsResult.None)
            {
                return "Server request failed.";
            }
            if (ret.Content.Result != EGetUpdatedChatsResult.Ok)
            {
                return "Operation failed.";
            }
            cbChats.Items.Clear();
            var list = ret.Content.UpdatedChatList;
            var clist = list.Select((x, ind) => new ChatlistItemView()
            {
                UserGuid = x.UserGuid,
                NewItemCount = x.NewItemCount,
                Index = ind
            }).ToArray();
            cbChats.Items.AddRange(clist);
            return "OK";
        }

        public async Task<string> MarkChatAnswered()
        {
            var userid = tbUserId.Text;
            var supportid = tbSupportId.Text;
            if (string.IsNullOrEmpty(userid))
                return "User id not provided.";
            if (string.IsNullOrEmpty(supportid))
                return "Support id not provided.";
            var req = new MarkChatAnsweredRequest()
            {
                UserGuid = userid,
                SupportGuid = supportid
            };
            var ret = await KlonsqApi.MarkChatAnswered(req);
            if (!ret.IsSuccessful || ret.Content.Result == EMarkChatAnsweredResult.None)
            {
                return "Server request failed.";
            }
            if (ret.Content.Result != EMarkChatAnsweredResult.Ok)
            {
                return "Operation failed.";
            }
            return "OK";
        }

        public async Task<string> AddItem2()
        {
            var content = tbIn2.Text?.Trim();
            if (string.IsNullOrEmpty(content))
                return "Chat message not provided.";

            Chat.UserGuid = tbUserId2.Text;
            if (string.IsNullOrEmpty(Chat.UserGuid))
            {
                var b = new byte[16];
                Random.Shared.NextBytes(b);
                Chat.UserGuid = new Guid(b).ToString();
                tbUserId2.Text = Chat.UserGuid;
            }
            var req = new AddItemRequest()
            {
                Content = content,
                UserGuid = tbUserId2.Text,
            };
            var ret = await KlonsqApi.AddItem(req);
            if (!ret.IsSuccessful || ret.Content.Result == EAddItemsResult.BadRequest ||
                ret.Content.Item?.Content == null)
            {
                return "Server request failed.";
            }
            var addeditem = ret.Content.Item;
            var nuewitems = Chat.Add([addeditem]);
            AddChatItemsToView(EChatView.TestUser, nuewitems);
            return "OK";
        }

        public async Task<string> GetChat2()
        {
            if (string.IsNullOrEmpty(tbUserId2.Text))
                return "User id not provided.";
            Chat.UserGuid = tbUserId2.Text;
            int lastid = -1;
            if (Chat.ChatItems != null && Chat.ChatItems.Count > 0)
            {
                var lastitem = Chat.ChatItems.Last();
                if (lastitem.Id != null)
                    lastid = lastitem.Id.Value;
            }
            var ret = await KlonsqApi.GetItems(Chat.UserGuid, lastid);
            if (!ret.IsSuccessful || ret.Content.Result == EGetItemsResult.None)
            {
                return "Server request failed.";
            }
            if (ret.Content.Items != null && ret.Content.Items.Count > 0)
            {
                var nuewitems = Chat.Add(ret.Content.Items);
                AddChatItemsToView(EChatView.TestUser, nuewitems);
            }
            return "OK";
        }

        public async Task<string> ClearChat2()
        {
            if (string.IsNullOrEmpty(tbUserId2.Text))
                return "User id not provided.";
            Chat.UserGuid = tbUserId2.Text;
            var ret = await KlonsqApi.ClearChat(Chat.UserGuid);
            if (!ret.IsSuccessful || ret.Content.Result == EClearChatResult.None)
            {
                return "Server request failed.";
            }
            Chat.ChatItems.Clear();
            tbOut2.Text = "";
            if (Chat.HasChangesSettings())
                Chat.SaveChat(ChatFileName);
            return "OK";
        }

        class ChatlistItemView
        {
            public string UserGuid { get; set; }
            public int NewItemCount { get; set; }
            public int Index { get; set; }
            public override string ToString()
            {
                return $"Chat-{Index}, count: {NewItemCount}";
            }
        }

        async Task<bool> Login()
        {
            try
            {
                var result = await KlonsqApi.Login(AdminGuid);
                if (!result.IsSuccessful) return false;
                //when returner with Ok(string) "" are added
                Token = result.Content?.Replace("\"", "");
                if (string.IsNullOrEmpty(Token))
                {
                    AddSignalText("Got empty token.");
                    return false;

                }
                AddSignalText("Got token.");
            }
            catch (Exception ex)
            {
                AddSignalText(ex.ToString());
                return false;
            }
            return true;
        }

        async Task<bool> Start()
        {
            if (Connection != null)
            {
                MessageBox.Show("Already started");
                return false;
            }
            var hubUrl = $"{ServerUrl}/signalhub?access_token={Token}";
            Connection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();

            Connection.On<string>("ReceiveMessage", (msg) =>
            {
                var tmsg = $"{DateTime.Now:HH:mm} {msg}";
                AddSignalText(tmsg, Color.Orange);
                WindowState = FormWindowState.Normal;
            });

            Connection.Reconnecting += error =>
            {
                var msg = $"{DateTime.Now:HH:mm} Reconnecting";
                AddSignalText(msg);
                return Task.CompletedTask;
            };

            Connection.Reconnected += connectionId =>
            {
                var msg = $"{DateTime.Now:HH:mm} Reconnected";
                AddSignalText(msg);
                return Task.CompletedTask;
            };

            Connection.Closed += error =>
            {
                var msg = $"{DateTime.Now:HH:mm} Closed";
                AddSignalText(msg);
                return Task.CompletedTask;
            };

            //Make proxy to hub based on hub name on server
            //var myHub = connection.CreateHubProxy("CustomHub");

            await Connection.StartAsync().ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                    var exc = task.Exception.GetBaseException();
                    var msg = $"{DateTime.Now:HH:mm} Error on StartAsync:\r\n{exc}";
                    AddSignalText(msg);
                }
                else
                {
                    AddSignalText("Connected");
                }
            });

            return true;
        }

        private async void miStart_Click(object sender, EventArgs e)
        {
            tbSignals.Text = $"Connecting to: {ServerUrl}\r\n";
            var rt = await Login();
            if (!rt) return;
            await Start();
        }

        private async void miStop_Click(object sender, EventArgs e)
        {
            if (Connection == null)
            {
                MessageBox.Show("Not started");
                return;
            }
            await Connection?.StopAsync();
        }

        private async void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Chat.SaveChat(ChatFileName);
            if (Connection != null)
            {
                await Connection?.StopAsync();
                await Connection.DisposeAsync();
                Connection = null;
            }
        }

        private async void miAdd_Click(object sender, EventArgs e)
        {
            var rt = await AddItem();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
                return;
            }
            tbIn.Text = null;
        }

        private async void miGet_Click(object sender, EventArgs e)
        {
            var rt = await GetChat();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void miClear_Click(object sender, EventArgs e)
        {
            var rt = await ClearChat();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void miGetUpdatedChats_Click(object sender, EventArgs e)
        {
            var rt = await GetUpdatedChats();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void miMarkChat_Click(object sender, EventArgs e)
        {
            var rt = await MarkChatAnswered();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void cbChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChats.SelectedIndex == -1 || cbChats.SelectedItem == null)
                return;
            var chattag = cbChats.SelectedItem as ChatlistItemView;
            tbUserId.Text = chattag.UserGuid;
            var rt = await GetChat();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void miAdd2_Click(object sender, EventArgs e)
        {
            var rt = await AddItem2();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
                return;
            }
            tbIn2.Text = null;
        }

        private async void miGet2_Click(object sender, EventArgs e)
        {
            var rt = await GetChat2();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

        private async void miClear2_Click(object sender, EventArgs e)
        {
            var rt = await ClearChat2();
            if (rt != "OK")
            {
                MessageBox.Show(rt);
            }
        }

    }
}
