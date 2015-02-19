namespace YTtoPlayer.Core.ViewModels
{
    using GalaSoft.MvvmLight;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class YouTubeUrlViewModel : ViewModelBase
    {
        public YouTubeUrlViewModel()
        {
            this.VideoUrl = "aasda";
        }

        public string VideoUrl { get; set; }
    }
}