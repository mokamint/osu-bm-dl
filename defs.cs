using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace osu_bm_dl
{
    class def
    {
        public String getRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }

        public void fileDownload(string sid)
        {
            String path = Properties.Settings.Default.gameDir;

            WebClient mywebClient = new WebClient();
            mywebClient.DownloadFile("http://mysite.com/myfile.txt", @"d:\myfile.txt");
        }
    }
}
