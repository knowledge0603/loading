//#####################################################################################
//★★★★★★★           http://www.cnpopsoft.com [华普软件]           ★★★★★★★
//★★★★★★★           华普软件-VB、C#专业论文与源码荟萃！           ★★★★★★★
//#####################################################################################

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CNPOPSOFT.Controls
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
            Application.Run(new frmMain());
        }
    }
}