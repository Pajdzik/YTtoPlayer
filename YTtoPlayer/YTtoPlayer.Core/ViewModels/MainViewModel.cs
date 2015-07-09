using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using YTtoPlayer.Core.Models;
using YTtoPlayer.Core.Resources;

namespace YTtoPlayer.Core.ViewModels {

    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(Settings settings, ILocationPicker locationPicker)
        {
            this.Settings = settings;
            this.YouTubeUrlViewModel = new YouTubeUrlViewModel(this);
            this.FileLocationViewModel = new FileLocationViewModel(this, locationPicker);
        }

        public YouTubeUrlViewModel YouTubeUrlViewModel { get; set; }

        public YouTubeVideoInfoViewModel YouTubeVideoInfoViewModel { get; set; }

        public FileLocationViewModel FileLocationViewModel { get; set; }

        public int WizardStep { get; set; }

        public Settings Settings { get; private set; }
    }
}