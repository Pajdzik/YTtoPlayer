using YTtoPlayer.Core.Models;

namespace YTtoPlayer.Core.ViewModels
{
    using System;
    using System.IO;
    using System.Net;

    using Newtonsoft.Json;

    public class VideoInfoViewModel
    {
        private readonly string videoUrl;

        public VideoInfoViewModel(string videoUrl)
        {
            this.videoUrl = videoUrl;
            this.LoadInfo();
        }

        private void LoadInfo()
        {
            WebRequest request =
                WebRequest.Create($"http://www.youtube.com/oembed?url={this.videoUrl}&format=json");

            using (WebResponse response = request.GetResponse())
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String s = reader.ReadToEnd();
                var a = JsonConvert.DeserializeObject<YoutubeInfo>(s);
            }

            
        }
    }
}