using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;




namespace HRMS_Project.Function.WebApi
{
    public class WebApi
    {
        public WebApi()
        {
        }

        public dynamic PostWebApi(string url, string json)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    //json = "{\"user\":\"test\"," +"\"password\":\"bla\"}";

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    return result;
                }
            }
            catch (Exception ex)
            {
                var result = ex.Message;
                return result;
            }    
        }
    }
}
