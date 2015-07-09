using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YTtoPlayer.Core.Models
{
    public class YouTubeVideoInfoService
    {
        private const string YouTubeVideoInfoUrl = "http://www.youtube.com/oembed?url={0}&format=json";
        private const string YouTubeThumbnailUrl = "https://i.ytimg.com/vi/{0}/default.jpg";
        private string apiKey;

        public YouTubeVideoInfoService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public YouTubeVideoInfo RetrieveYouTubeVideoInfo(Uri videoUri)
        {
            var foo = RetrieveYouTubeVideoInfoAsync(videoUri);
            foo.Wait();
            return foo.Result;
        }

        public async Task<YouTubeVideoInfo> RetrieveYouTubeVideoInfoAsync(Uri videoUri)
        {
            var request = WebRequest.Create(string.Format(YouTubeVideoInfoUrl, videoUri.AbsoluteUri));
            var videoInfoJson = await DownloadVideoInfoJson(request);

            var youTubeVideoInfo = JsonConvert.DeserializeObject<YouTubeVideoInfo>(videoInfoJson);
            youTubeVideoInfo.VideoUri = videoUri;

            return youTubeVideoInfo;
        }

        private async Task<string> DownloadVideoInfoJson(WebRequest request)
        {
            var youTubeInfoResponse = request.GetResponseAsync();

            await youTubeInfoResponse;

            var webResponse = (HttpWebResponse) youTubeInfoResponse.Result;
            string videoInfoJson;

            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                videoInfoJson = streamReader.ReadToEnd();
            }

            return videoInfoJson;
        }
    }
}