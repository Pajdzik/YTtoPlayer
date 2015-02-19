namespace YTtoPlayer.Core.ViewModels
{
    using Caliburn.Micro;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class MainViewModel : PropertyChangedBase
    {
        public MainViewModel()
        {
            this.YouTubeVideoUrl = "asb";
        }

        public string YouTubeVideoUrl { get; set; }
    }
}