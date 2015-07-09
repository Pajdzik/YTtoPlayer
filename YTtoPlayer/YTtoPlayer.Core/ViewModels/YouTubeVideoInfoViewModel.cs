using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using PropertyChanged;
using YTtoPlayer.Core.Models;

namespace YTtoPlayer.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class YouTubeVideoInfoViewModel : ViewModelBase
    {
        private readonly MainViewModel mainViewModel;

        public YouTubeVideoInfoViewModel(MainViewModel mainViewModel, IList<YouTubeVideoInfo> youTubeVideoInfos)
        {
            this.mainViewModel = mainViewModel;
            this.YouTubeVideoInfos = new ObservableCollection<YouTubeVideoInfo>(youTubeVideoInfos);
        }

        public YouTubeVideoInfo SelectedYouTubeVideoInfo { get; set; }

        public ObservableCollection<YouTubeVideoInfo> YouTubeVideoInfos { get; set; }
    }
}