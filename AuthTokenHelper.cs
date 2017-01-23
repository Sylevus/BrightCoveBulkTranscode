using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BrightcoveBulkTranscode
{
   public static class AuthTokenHelper
   {
      public static string FetchAccessToken()
      {
         string accessToken = string.Empty;
         using (var wb = new WebClient())
         {
            wb.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string clientFormat = string.Format("{0}:{1}", Brightcove.Default.Client, Brightcove.Default.ClientSecret);
            var clientSecretBytes = System.Text.Encoding.UTF8.GetBytes(clientFormat);        

            wb.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(clientSecretBytes));

            var data = new NameValueCollection();
            data["grant_type"] = "client_credentials";

            var response = wb.UploadValues(Brightcove.Default.AccessTokenUrl, "POST", data);
            string content = Encoding.UTF8.GetString(response);
            var json = "[" + content + "]"; // change this to array
            var objects = JArray.Parse(json); // parse as array  
            foreach (JObject o in objects.Children<JObject>())
            {
               foreach (JProperty p in o.Properties())
               {
                  if (p.Name == "access_token")
                  {
                     accessToken = p.Value.ToString();
                  }
                  string name = p.Name;
                  string value = p.Value.ToString();
                //  Console.Write(name + ": " + value);
               }
            }
         }

         return accessToken;
      }
   }
}
