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
        public MainWindow()
        {
            InitializeComponent();
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
            // STUB: To next image
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // STUB: To last image
        }
    }
}
