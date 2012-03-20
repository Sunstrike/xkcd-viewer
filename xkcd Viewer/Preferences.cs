using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xkcd_Viewer
{
    public partial class Preferences : Form
    {
        // Instance vars
        ViewerCore core;
        
        internal Preferences(ViewerCore gotcore)
        {
            InitializeComponent();
            core = gotcore;

            if (xkcd_Viewer.Properties.Settings.Default.offlineMode)
                offlineViewingButton.Text = "Disable...";
            else
                offlineViewingButton.Text = "Enable...";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Self explanatory
        }

        private void offlineViewingButton_Click(object sender, EventArgs e)
        {
            // Warn if disabling about purging cache
            if (xkcd_Viewer.Properties.Settings.Default.offlineMode)
                MessageBox.Show("Run 'Purge Images' to reclaim the space occupied by Offline Mode, otherwise this will not save any already allocated space.", "Cache Maintenance");
            
            // Toggle the setting
            xkcd_Viewer.Properties.Settings.Default.offlineMode = !xkcd_Viewer.Properties.Settings.Default.offlineMode;

            // Change button text
            if (xkcd_Viewer.Properties.Settings.Default.offlineMode)
                offlineViewingButton.Text = "Disable...";
            else
                offlineViewingButton.Text = "Enable...";
        }

        private void jettisonButton_Click(object sender, EventArgs e)
        {
            core.jettisonDB(); // Self explanatory
        }

        private void imagePurgeButton_Click(object sender, EventArgs e)
        {
            // Generic warning goes here
            MessageBox.Show("This operation could take a while depending on how many images have been locally stored. Do not kill the program.\n\nPress Okay to continue.", "Warning");

            // Tell core to delete all images.
            core.deleteAllImages();
        }
    }
}
