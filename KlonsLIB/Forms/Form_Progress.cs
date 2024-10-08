﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KlonsLIB.Forms
{
    public partial class Form_Progress : MyFormBase
    {
        public Form_Progress()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        public Action OnCancel = null;
        public Action RunThis = null;
        private bool CanClose = false;
        public int UpdateIntervalMS { get; set; } = 100;

        private System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();

        private void Form_Progress_Load(object sender, EventArgs e)
        {

        }

        private T DoInvodke<T>(Func<T> func)
        {
            if (InvokeRequired) return (T)Invoke(func);
            else return func();
        }

        private void DoInvodke<T>(Action<T> act, T value)
        {
            if (InvokeRequired) Invoke(act, value);
            else act(value);
        }

        public int MaxProgress
        {
            get => progressBar1.Maximum;
            set => DoInvodke((mpr) => {progressBar1.Maximum = mpr;}, value);
        }

        long lastWatch = -1;
        public int Progress
        {
            get { return progressBar1.Value; }
            set
            {
                if (value > progressBar1.Maximum) value = progressBar1.Maximum;
                if (value == progressBar1.Value) return;
                if (!Timer.IsRunning) return;
                if (lastWatch == -1)
                    lastWatch = Timer.ElapsedMilliseconds;
                if (value < MaxProgress && Timer.ElapsedMilliseconds - lastWatch < UpdateIntervalMS) return;
                DoInvodke((pr) => { SetProgress(pr); }, value);
                lastWatch = Timer.ElapsedMilliseconds;
            }
        }

        private void SetProgress(int value)
        {
            progressBar1.Value = value;
        }

        public string Message
        {
            get => DoInvodke(() => { return label1.Text; });
            set => DoInvodke((s) => { label1.Text = s; }, value);
        }

        public new void Close()
        {
            CanClose = true;
            if(Modal)
                DialogResult = DialogResult.OK;
            else
                base.Close();
        }

        private void cmCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel != null)
            {
                var onc = OnCancel;
                OnCancel = null;
                onc();
            }
        }

        private void Form_Progress_Shown(object sender, EventArgs e)
        {
            Timer.Start();
            if (RunThis != null) RunThis();
        }
        private void Form_Progress_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnCancel = null;
            RunThis = null;
            Timer.Stop();
        }
        private void Form_Progress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose)
            {
                e.Cancel = true;
                return;
            }
        }

    }


    public static class FolderBrowserLauncher
    {
        /// <summary>
        /// Using title text to look for the top level dialog window is fragile.
        /// In particular, this will fail in non-English applications.
        /// </summary>
        const string _topLevelSearchString = "Browse For Folder";

        /// <summary>
        /// These should be more robust.  We find the correct child controls in the dialog
        /// by using the GetDlgItem method, rather than the FindWindow(Ex) method,
        /// because the dialog item IDs should be constant.
        /// </summary>
        const int _dlgItemBrowseControl = 0;
        const int _dlgItemTreeView = 100;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Some of the messages that the Tree View control will respond to
        /// </summary>
        private const int TV_FIRST = 0x1100;
        private const int TVM_SELECTITEM = (TV_FIRST + 11);
        private const int TVM_GETNEXTITEM = (TV_FIRST + 10);
        private const int TVM_GETITEM = (TV_FIRST + 12);
        private const int TVM_ENSUREVISIBLE = (TV_FIRST + 20);

        /// <summary>
        /// Constants used to identity specific items in the Tree View control
        /// </summary>
        private const int TVGN_ROOT = 0x0;
        private const int TVGN_NEXT = 0x1;
        private const int TVGN_CHILD = 0x4;
        private const int TVGN_FIRSTVISIBLE = 0x5;
        private const int TVGN_NEXTVISIBLE = 0x6;
        private const int TVGN_CARET = 0x9;


        /// <summary>
        /// Calling this method is identical to calling the ShowDialog method of the provided
        /// FolderBrowserDialog, except that an attempt will be made to scroll the Tree View
        /// to make the currently selected folder visible in the dialog window.
        /// </summary>
        /// <param name="dlg"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static DialogResult ShowFolderBrowser(FolderBrowserDialog dlg, IWin32Window parent = null)
        {
            DialogResult result = DialogResult.Cancel;
            int retries = 10;

            using (System.Windows.Forms.Timer t = new System.Windows.Forms.Timer())
            {
                t.Tick += (s, a) =>
                {
                    if (retries > 0)
                    {
                        --retries;
                        IntPtr hwndDlg = FindWindow((string)null, _topLevelSearchString);
                        if (hwndDlg != IntPtr.Zero)
                        {
                            IntPtr hwndFolderCtrl = GetDlgItem(hwndDlg, _dlgItemBrowseControl);
                            if (hwndFolderCtrl != IntPtr.Zero)
                            {
                                IntPtr hwndTV = GetDlgItem(hwndFolderCtrl, _dlgItemTreeView);

                                if (hwndTV != IntPtr.Zero)
                                {
                                    IntPtr item = SendMessage(hwndTV, (uint)TVM_GETNEXTITEM, new IntPtr(TVGN_CARET), IntPtr.Zero);
                                    if (item != IntPtr.Zero)
                                    {
                                        SendMessage(hwndTV, TVM_ENSUREVISIBLE, IntPtr.Zero, item);
                                        retries = 0;
                                        t.Stop();
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        //
                        //  We failed to find the Tree View control.
                        //
                        //  As a fall back (and this is an UberUgly hack), we will send
                        //  some fake keystrokes to the application in an attempt to force
                        //  the Tree View to scroll to the selected item.
                        //
                        t.Stop();
                        SendKeys.Send("{TAB}{TAB}{DOWN}{DOWN}{UP}{UP}");
                    }
                };

                t.Interval = 1000;
                t.Start();

                result = dlg.ShowDialog(parent);
            }

            return result;
        }
    }

}
