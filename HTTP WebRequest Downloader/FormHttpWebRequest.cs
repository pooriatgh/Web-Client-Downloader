using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTP_WebRequest_Downloader
{
    public partial class FormHttpWebRequest : Form
    {
        public FormHttpWebRequest()
        {
            InitializeComponent();
        }

        private void Btn_Timeout_Click(object sender, EventArgs e)
        {
            try
            {
                var webTimeout = new WebClientWithTimeOut();
                var url = "http://google.com";
                webTimeout.Timeout = Convert.ToInt32(TXT_Timeout.Text);
                var text = webTimeout.DownloadString(url);
                MessageBox.Show(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
