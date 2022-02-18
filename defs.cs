using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Drawing;

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

        public String bmStatus(String status)
        {
            switch (status)
            {
                case "-1":
                    return "WIP (제작 중)";                    
                case "-2":
                    return "Graveyard";                    
                case "0":
                    return "Pending";                   
                case "1":
                    return "Ranked";                    
                case "2":
                    return "Approved";                    
                case "3":
                    return "Qualified";                   
                case "4":
                    return "Loved";
                default:
                    return "None";
            }
        }
    }
}
