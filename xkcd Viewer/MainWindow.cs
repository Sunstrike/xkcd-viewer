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
    public partial class MainWindow : Form
    {
        // Instance vars
        int currentID;
        int currentMaxID;
        ViewerCore core;

        public MainWindow()
        {
            InitializeComponent();
            core = new ViewerCore();

            // Get latest comic ID
            currentMaxID = core.getMaxID();

            if (xkcd_Viewer.Properties.Settings.Default.lastComicID != -1)
            {
                // Obviously the program has been used, so we'll restore state
                __goToID(xkcd_Viewer.Properties.Settings.Default.lastComicID);
                currentID = xkcd_Viewer.Properties.Settings.Default.lastComicID;
            }
            else
            {
                // Must be first run; go-to latest ID
                __goToID(currentMaxID);
                currentID = currentMaxID;
                xkcd_Viewer.Properties.Settings.Default.lastComicID = currentMaxID;
            }
        }

        private void __goToID(int ID)
        {
            Image img;
            if (ID == 1) // If ID is 1, disable the back button (There is no zero!)
                backButton.Enabled = false;
            else
                backButton.Enabled = true;

            if (ID == currentMaxID) // If ID is equal to the highest ID, disable Forward button
                forwardButton.Enabled = false;
            else
                forwardButton.Enabled = true;

            statusText.Text = "Getting comic " + ID.ToString() + "...";
            statusBar.Visible = true;
            currentID = ID;
            Application.DoEvents();

            img = core.getImage(ID);
            if (img == null)
                statusText.Text = "ERR: Could not get image for comic " + ID.ToString();
            else
            {
                this.Text = "xkcd Viewer - " + core.getTitle(ID);
                pictureBox.Image = img;
                statusText.Text = "Ready";
                statusBar.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This action comes from the 'Exit' command so...
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STUB: Add About... dialog.
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STUB: Save current image to drive
        }

        private void saveJSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STUB: Get and save raw JSON file
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STUB: Load prefs window
        }

        private void searchGoButton_Click(object sender, EventArgs e)
        {
            // STUB: Call search routine
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            __goToID(currentID + 1);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            __goToID(currentID - 1);
        }

        private void goToIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STUB: Show go-to dialog
        }
    }
}
