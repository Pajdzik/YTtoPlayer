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
                WebRequest.Create(string.Format("http://www.youtube.com/oembed?url={0}&format=json", this.videoUrl));

            using (WebResponse response = request.GetResponse())
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var s = reader.ReadToEnd();
            }

            
        }
    }
}