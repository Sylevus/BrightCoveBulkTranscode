using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightcoveBulkTranscode
{
   public class Video
   {
      public Video(string videoId)
      {
         VideoId = videoId;
      }
      public string VideoId { get; set; }
      public string ErrorString { get; set; }
   }
}
