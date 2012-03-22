using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

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

        internal void __goToID(int ID)
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
            currentID = ID;
            Application.DoEvents();

            img = core.getImage(ID);
            if (img == null)
                statusText.Text = "ERR: Could not get image for comic " + ID.ToString();
            else
            {
                this.Text = "xkcd Viewer - [" + ID.ToString() + "] " + core.getTitle(ID);
                pictureBox.Image = img;
                statusText.Text = "Ready";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This action comes from the 'Exit' command so...
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSaveDialog.FileName = currentID.ToString();
            ImageSaveDialog.ShowDialog();
        }

        // 'Catchers Mitt' for Image save
        private void ImageSaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = ImageSaveDialog.FileName;
            Debug.WriteLine("[INFO] Saving image to " + path);
            try
            {
                core.getImage(currentID).Save(path);
            }
            catch
            {

            }
        }

        private void saveJSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSONSaveDialog.FileName = currentID.ToString();
            JSONSaveDialog.ShowDialog();
        }

        // 'Catchers Mitt' for JSON save
        private void JSONSaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = JSONSaveDialog.FileName;
            Debug.WriteLine("[INFO] Saving JSON to " + path);
            try
            {
                byte[] JSON = __getXkcdJSON(currentID);
                File.WriteAllBytes(path, JSON);
            }
            catch (Exception ex)
            { Debug.WriteLine("[ERR] Exception caught: " + ex.Message); } // No need to catch; just avoid the rabid exception
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Preferences(core).Show();
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
            new GoToDialog(this, core).Show();
        }

        private void copyURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://xkcd.com/" + currentID); // Copy current comic's URL to clipboard, obviously
        }

        // From ASComicAccess (it's private so we copy it)
        static private byte[] __getXkcdJSON(int id)
        {
            WebClient connectAgent = new WebClient();

            try
            {
                // Unlike in ASLib, we do not need to do parsing on this. So why should we?
                byte[] rawData = connectAgent.DownloadData("http://xkcd.com/" + id.ToString() + "/info.0.json");
                return rawData;
            }
            catch (WebException)
            {
                MessageBox.Show("Could not get JSON data.\n\n Are you online?");
                throw;
            }
        }
    }
}
