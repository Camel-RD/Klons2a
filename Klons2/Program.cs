using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlonsF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetDefaultFont(new Font(new FontFamily("Microsoft Sans Serif"), 10f));
            if (!AdjustCurrentCulture()) return;
            Application.Run(new Form_Main());
        }

        static bool AdjustCurrentCulture()
        {
            try
            {
                var ci_lv = new CultureInfo("lv-LV", true);
                //ci_lv.NumberFormat.NumberDecimalSeparator = ".";
                ci_lv.NumberFormat.NumberGroupSeparator = " ";
                CultureInfo.CurrentCulture = ci_lv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neizdevās nomainīt reģionālos iestatijumus uz 'lv-LV'.", "kļūda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
