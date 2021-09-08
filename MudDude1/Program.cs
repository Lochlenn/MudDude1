using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudDude1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // first chance exception catch,  use to catch all exceptions
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                Console.WriteLine(eventArgs.Exception.ToString());
                
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }


    }
}
