using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace RA2_YR_Config
{
    public class TWebClient : WebClient
    {
        private int Timeout = 10000;
        public TWebClient()
        {
            this.Proxy = null;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var webRequest = base.GetWebRequest(address);
            webRequest.Timeout = Timeout;
            return webRequest;
        }
    }
}
