using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace HospitalMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            var youCanUseHMStill = new DateTime(2025, 2, 1);
            if (DateTime.Today > youCanUseHMStill)
            {
                MessageBox.Show("trial version Time is ended! please contact software owners");
                Application.Exit();
               
            }
            else
                Application.Run(new Splush());
        }
    }
}
