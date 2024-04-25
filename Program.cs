using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DWI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            /*if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationType"].ToString()))
            {
                Application.Run(new login());
            }
            else
            {
                Global.LoginUserId = "dwiSupport";
                Global.UserRole = "DWI USER";
                Application.Run(new frmHome());
            }*/
            if (AnotherInstanceExists())

            {

                MessageBox.Show("You cannot run more than one instance of this application.", "Only one instance allowed to run", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                return;

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new login());
           //Application.Run(new frmSetting());
        }

        static bool AnotherInstanceExists()

        {

            Process currentRunningProcess = Process.GetCurrentProcess();

            Process[] listOfProcs = Process.GetProcessesByName(currentRunningProcess.ProcessName);



            foreach (Process proc in listOfProcs)

            {

                if ((proc.MainModule.FileName == currentRunningProcess.MainModule.FileName) && (proc.Id != currentRunningProcess.Id))

                    return true;

            }

            return false;

        }
    }
}

