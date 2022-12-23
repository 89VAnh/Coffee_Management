using Anh_Coffee.View;
using System;
using System.Windows.Forms;

namespace Anh_Coffee
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInfo());
        }
    }
}
