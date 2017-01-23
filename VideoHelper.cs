using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BrightcoveBulkTranscode
{
   public static class VideoHelper
   {
      public static List<Video> FetchVideos()
      {
         List<Video> videos = new List<Video>();
         string result = string.Empty;
         string url = string.Format(Brightcove.Default.IngressVideoSearch, Brightcove.Default.IngressToken, 0);
         try
         {
            using (WebClient httpWebClient = new WebClient())
            {
               result = httpWebClient.DownloadString(url);
            }
         }
         catch (WebException ex)
         {
            Console.WriteLine(ex.Message);
         }

         JavaScriptSerializer js = new JavaScriptSerializer();
         dynamic dynObj = js.DeserializeObject(result);
         int pageSize = Brightcove.Default.PageSize;

         int totalVideos = dynObj["total_count"];
         int pages = totalVideos / pageSize;
         for (int i = 1; i <= pages + 1; i++)
         {
            foreach (var item in dynObj["items"])
            {
               string videoId = (item["id"].ToString());
               videos.Add(new Video(videoId));
            }

            url = string.Format(Brightcove.Default.IngressVideoSearch, Brightcove.Default.IngressToken, i);
            using (WebClient httpWebClient = new WebClient())
            {
               result = httpWebClient.DownloadString(url);
            }

            dynObj = js.DeserializeObject(result);
         }

         return videos;
      }

      public static void RetranscodeVideo(string authToken, Video video, string transcodeSettings)
      {
         try
         {
            using (var wb = new WebClient())
            {
               string transcodeUrl = string.Format(Brightcove.Default.RetranscodeUrl, Brightcove.Default.AccountNumber, video.VideoId);
               wb.Headers.Add("user-agent",
                      "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
               wb.Headers.Add("Authorization", "Bearer " + authToken);
               wb.Headers.Add("Content-Type", "application/json");

             
               var response = wb.UploadString(transcodeUrl, "POST", transcodeSettings);
            }
         }
         catch(Exception ex)
         {
            video.ErrorString = ex.Message;
            Console.WriteLine(string.Format("ERROR - {0} - {1}", video.VideoId, ex.Message));
            Console.WriteLine();
         }
         
      }
   }
}
