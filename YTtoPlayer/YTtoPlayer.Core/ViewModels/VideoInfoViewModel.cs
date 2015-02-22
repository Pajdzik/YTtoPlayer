using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace YTtoPlayer.Core.ViewModels
{
    using Google.Apis.YouTube.v3.Data;

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
            
        }
    }
}