namespace YTtoPlayer.Core.ViewModels
{
    using Caliburn.Micro;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class YouTubeUrlViewModel : PropertyChangedBase
    {
        public YouTubeUrlViewModel()
        {
            this.VideoUrl = "aasda";
        }

        public string VideoUrl { get; set; }
    }
}