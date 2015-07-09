using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using YTtoPlayer.Core.Models;

namespace YTtoPlayer.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class YouTubeUrlViewModel : ViewModelBase
    {
        private readonly MainViewModel mainViewModel;
        private readonly YouTubeVideoInfoService youTubeVideoInfoService;

        public YouTubeUrlViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            string apiKey = this.mainViewModel.Settings.ApiKey;
            youTubeVideoInfoService = new YouTubeVideoInfoService(apiKey);
            RetrieveInfoCommand = new RelayCommand(RetrieveInfo);
        }

        public string VideoUrl { get; set; } = @"https://www.youtube.com/watch?v=7ImE8QV5Fs0"; //string.Empty;

        public ICommand RetrieveInfoCommand { get; private set; }

        public async Task<YouTubeVideoInfoViewModel> LoadVideoInfoViewModel()
        {
            var uri = new Uri(VideoUrl);
            var info = await youTubeVideoInfoService.RetrieveYouTubeVideoInfoAsync(uri);
            return new YouTubeVideoInfoViewModel(mainViewModel, new List<YouTubeVideoInfo> {info});
        }

        public async void RetrieveInfo()
        {
            mainViewModel.YouTubeVideoInfoViewModel = await LoadVideoInfoViewModel();
            mainViewModel.WizardStep++;
        }
    }
}