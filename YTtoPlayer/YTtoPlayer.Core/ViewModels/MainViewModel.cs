namespace YTtoPlayer.Core.ViewModels
{
    using Caliburn.Micro;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class MainViewModel : PropertyChangedBase
    {
        public MainViewModel()
        {
            this.YouTubeUrlViewModel = new YouTubeUrlViewModel();
        }

        public YouTubeUrlViewModel YouTubeUrlViewModel { get; set; }
    }
}