﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KlonsF.Classes;

namespace KlonsF.Forms
{
    public partial class Form_About : MyFormBaseF
    {
        public Form_About()
        {
            InitializeComponent();
            Font f = lbTitle.Font;
            CheckMyFontAndColors();
            lbTitle.Font = new Font(f.FontFamily, f.Size * 4, f.Style);
            lbVersionStr.Text = "versija " + MyData.VersionStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_About_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_About_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
