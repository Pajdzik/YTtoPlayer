using System;
using System.Text.RegularExpressions;

namespace YTtoPlayer.Core.Models
{
    public class YouTubeVideoInfo
    {
        private const string YouTubeThumbnailUrl = @"https://i.ytimg.com/vi/{0}/default.jpg";

        private const string IdRegexPattern = @"^(?:http(?:s)?:\/\/)?(?:www\.)?(?:m\.)?(?:youtu\.be\/|youtube\.com\/(?:(?:watch)?\?(?:.*&)?v(?:i)?=|(?:embed|v|vi|user)\/))([^\?&\""'>]+)";

        private readonly Regex idRegex = new Regex(IdRegexPattern);

        private string id;

        public YouTubeVideoInfo()
        {
        }

        public YouTubeVideoInfo(Uri videoUri)
        {
            VideoUri = videoUri;
        }

        public Uri VideoUri { get; set; }

        public int ThumbnailHeight { get; set; }

        public string Type { get; set; }

        public string ThumbnailUrl { get; set; }

        public string ProviderUrl { get; set; }

        public int ThumbnailWidth { get; set; }

        public int Width { get; set; }

        public string Version { get; set; }

        public string AuthorUrl { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Html { get; set; }

        public string ProviderName { get; set; }

        public int Height { get; set; }

        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(this.id))
                {
                    this.id = this.GetId(this.VideoUri.AbsoluteUri);
                }

                return id;
            }

            set { id = value; }
        }

        public string ImagePath => string.Format(YouTubeThumbnailUrl, this.Id);

        private string GetId(string videoUrl)
        {
            Match idMatch = this.idRegex.Match(videoUrl);
            Group idGroup = idMatch.Groups[1];
            return idGroup.Value;
        }

    }
}