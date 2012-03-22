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
    public partial class GoToDialog : Form
    {
        MainWindow caller;
        ViewerCore core;
        
        internal GoToDialog(MainWindow main, ViewerCore gotcore)
        {
            InitializeComponent();
            caller = main;
            core = gotcore;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(idBox.Text);
                int maxID = core.getMaxID();

                if ((i < 0) || (i > maxID))
                    MessageBox.Show("Invalid value: Please enter a valid comic ID.");
                else
                {
                    caller.__goToID(int.Parse(idBox.Text));
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid value: Please enter a valid comic ID.");
            }
        }
    }
}
