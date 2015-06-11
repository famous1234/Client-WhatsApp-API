using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace WhatsAppPort
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new frmLogin());
        }

        private static void ThreadStart()
        {
            Application.Run(new frmMonitor()); // <-- other form started on its own UI thread

        }
    }
}
