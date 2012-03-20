using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace xkcd_Viewer
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

            ViewerCore core = new ViewerCore();
            if (xkcd_Viewer.Properties.Settings.Default.isFirstRun) // Call the Out-Of-Box-Experience if needed
                Application.Run(new FirstRun(core));
            
            Application.Run(new MainWindow()); // Continue to main window
        }
    }
}
