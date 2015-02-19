namespace YTtoPlayer.Core.ViewModels
{
    using GalaSoft.MvvmLight;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.YouTubeUrlViewModel = new YouTubeUrlViewModel();
        }

        public YouTubeUrlViewModel YouTubeUrlViewModel { get; set; }
    }
}