using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Web_Client_Downloader
{
    public class WebClientHandler
    {
        public Uri Url { get; }
        private WebClient webClient;
        public WebClientHandler(string url) {
            this.Url = new Uri(url);
            webClient = new WebClient();
        }
        public string TestDownloadString()
        {
            return webClient.DownloadString(Url);
        }
        public byte[] TestDownloadData()
        {
            return webClient.DownloadData(Url);
        }
        public void TestDownloadFile(string fileName)
        {
            webClient.DownloadFile(Url, fileName);
        }
        public string TestOpenRead()
        {
            using (var stream = webClient.OpenRead(Url))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    var text = streamReader.ReadToEnd();
                    return text;
                }
            }
        }
    }
}
