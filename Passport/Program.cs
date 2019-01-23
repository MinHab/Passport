using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Passport
{
    static class Program
    {
        public static DataClasses.Opr loggedUser = new DataClasses.Opr();
        public static bool openMain = false;
        public static string loggedOpr = "12345678";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new passportAppFrm());
            //Application.Run(new regfrm());
            //Application.Run(new AdminForms.fileUpdate());
           
            //Application.Run(new frmUser());
            Application.Run(new frmLogin());
            if (openMain)
            {
                Application.Run(new Passport.frmMain());
            }
        }
    }
}
