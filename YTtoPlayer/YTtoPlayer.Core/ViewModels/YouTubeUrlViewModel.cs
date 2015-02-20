namespace YTtoPlayer.Core.ViewModels
{
    using GalaSoft.MvvmLight;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class YouTubeUrlViewModel : ViewModelBase
    {
        public YouTubeUrlViewModel()
        {
        }

        public string VideoUrl { get; set; }
    }
}