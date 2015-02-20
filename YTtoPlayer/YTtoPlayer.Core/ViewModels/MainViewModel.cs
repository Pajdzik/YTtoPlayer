namespace YTtoPlayer.Core.ViewModels
{
    using System.Windows.Input;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.YouTubeUrlViewModel = new YouTubeUrlViewModel();

            this.LoadVideoInfoCommand = new RelayCommand(this.LoadVideoInfo);
        }

        public YouTubeUrlViewModel YouTubeUrlViewModel { get; set; }

        public ICommand LoadVideoInfoCommand { get; set; }

        private void LoadVideoInfo()
        {
            
        }
    }
}