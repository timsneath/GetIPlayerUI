using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GetIPlayerUI
{
    public partial class OptionsDialogControl : UserControl
    {
        public OptionsDialogControl()
        {
            InitializeComponent();
        }

        private void portTextBox_Validating(object sender, CancelEventArgs e)
        {
            int port = -1;
            portValidationLabel.Visible = !(int.TryParse(portTextBox.Text, out port) && (port > 0) && (port < 65536));
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Visible = false;
        }

        private void pathLocationButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Properties.Settings.Default.GetIPlayerPath;
            openFileDialog.Filter = "get_iplayer.pl|get_iplayer.pl";
            openFileDialog.Title = "Select the location of the get_iplayer.pl file";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathLocationTextBox.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }
        }
    }
}
