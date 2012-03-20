using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace xkcd_Viewer
{
    public partial class FirstRun : Form
    {
        ViewerCore core;

        internal FirstRun(ViewerCore givenCore)
        {
            core = givenCore;
            InitializeComponent();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            // BEGIN FIRST LAUNCH
            offlineModeCheck.Enabled = false;            
            launchButton.Enabled = false;
            launchButton.Text = "Launching...";
            Application.DoEvents();

            // Check for offline mode
            if (offlineModeCheck.Checked)
                xkcd_Viewer.Properties.Settings.Default.offlineMode = true; // Turn ON offline mode
            else
                xkcd_Viewer.Properties.Settings.Default.offlineMode = false; // Turn OFF offline mode (not strictly needed, but just in case)
            
            xkcd_Viewer.Properties.Settings.Default.Save();

            // Spool off some of the heavy processing to another thread
            Debug.WriteLine("[INFO] Creating worker thread.");
            Thread worker = new Thread(new ThreadStart(doLoad));
            worker.Name = "StartupWorker";
            worker.Start();

            while (worker.IsAlive)
            {
                Thread.Sleep(100);
            }

#if !DEBUG
            // Disable first run flag and close form, returning to Program.cs
            // This code is DISABLED during debug to make things less painful to fix.
            xkcd_Viewer.Properties.Settings.Default.isFirstRun = false;
            xkcd_Viewer.Properties.Settings.Default.Save();
#else
            Debug.WriteLine("[DERP] Derping around instead of saving correct first-run state (DEBUG mode)");
            xkcd_Viewer.Properties.Settings.Default.isFirstRun = true;
            xkcd_Viewer.Properties.Settings.Default.Save();
#endif
            this.Close();
        }

        private void doLoad()
        {
            // Call the controller to setup the first issue
            core.FirstRunSetup();
        }
    }
}
