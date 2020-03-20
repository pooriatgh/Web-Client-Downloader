using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_WebRequest_Downloader
{
    class WebClientWithTimeOut:WebClient
    {
        public int Timeout { get; set; }
        public WebClientWithTimeOut()
        {
            Timeout = 60000;
        }
        protected override WebRequest GetWebRequest(Uri address)
        {
            var WR = base.GetWebRequest(address);
            WR.Timeout = Timeout;
            return WR;
        }
    }
}
