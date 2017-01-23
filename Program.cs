using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrightcoveBulkTranscode
{
   public class Program
   {
      //http://docs.brightcove.com/en/video-cloud/di-api/samples/di-retranscode.html
      static void Main(string[] args)
      {
        
         List<Video> videos = new List<Video>();
         videos.AddRange(VideoHelper.FetchVideos());

         int counter = 1;
         string authToken = AuthTokenHelper.FetchAccessToken();
         string transcodeSettings = JsonConvert.SerializeObject(new { master = new { use_archived_master = Brightcove.Default.UseArchivedMaster }, profile = Brightcove.Default.RetranscodeIngressProfile });
         var outputFile = File.CreateText("C:\\BrightcoveOutput.data");
         try
         {
            foreach (var video in videos)
            {
               VideoHelper.RetranscodeVideo(authToken, video, transcodeSettings);
               outputFile.WriteLine(JsonConvert.SerializeObject(video));
               if (counter % 20 == 0)
               {
                  // throttle to 20 requests per minute
                  // request new auth token every 20 requests     
                  Console.WriteLine(string.Format("Finished {0} Files, sleeping 60 seconds", counter));
                  Thread.Sleep(1000 * 60);
                  authToken = AuthTokenHelper.FetchAccessToken();
               }

               if (counter % 100 == 0)
               {
                  // throttle to 100 requests per hour
                  Console.WriteLine(string.Format("Finished {0} Files, sleeping 55 minutes", counter));
                  Thread.Sleep(1000 * 60 * 55); // 55 minutes
                  authToken = AuthTokenHelper.FetchAccessToken();
               }

               counter++;
            }

            outputFile.Close();
         }
         catch(Exception ex)
         {
            outputFile.WriteLine("Closing Error!!!");
            outputFile.WriteLine(ex.Message);         }
      }
   }
}
