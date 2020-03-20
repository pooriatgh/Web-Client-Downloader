using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Web_Client_Downloader
{
    public partial class FormDashbord : Form
    {
        public FormDashbord()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TXT_Url.Text))
            {
                var checkedButton = GB_WebClientMethods.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
                var webClientHandler = new WebClientHandler(TXT_Url.Text);
                RTXT_Content.Text = String.Empty;
                if (CB_Synchronization.SelectedItem.ToString().Equals("Sync"))
                {
                    if (checkedButton.Text.Equals("DownloadString"))
                    {
                        RTXT_Content.Text = webClientHandler.TestDownloadString();
                    }
                    else if (checkedButton.Text.Equals("DownloadData"))
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            byte[] data = webClientHandler.TestDownloadData();
                            File.WriteAllBytes(saveFileDialog.FileName, data);

                        }
                    }
                    else if (checkedButton.Text.Equals("DownloadFile"))
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            webClientHandler.TestDownloadFile(saveFileDialog.FileName);
                        }
                    }
                    else if (checkedButton.Text.Equals("OpenRead"))
                    {
                        RTXT_Content.Text = webClientHandler.TestOpenRead();
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Fill the Url textbox.");
            }
        }

        private void FormDashbord_Load(object sender, EventArgs e)
        {
            CB_Synchronization.SelectedIndex = 0;
        }
    }
}
