using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using YTtoPlayer.Core.Models;

namespace YTtoPlayer.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class FileLocationViewModel : ViewModelBase
    {
        private readonly MainViewModel mainViewModel;
        private readonly ILocationPicker locationPicker;

        public FileLocationViewModel(MainViewModel mainViewModel, ILocationPicker locationPicker)
        {
            this.mainViewModel = mainViewModel;
            this.locationPicker = locationPicker;

            this.OpenFilePickerCommand = new RelayCommand(this.OpenFilePicker);
        }

        public string FileLocation { get; set; }

        public ICommand OpenFilePickerCommand { get; private set; }

        private void OpenFilePicker()
        {
            string location = this.locationPicker.ChooseLocation();
            this.FileLocation = location;
        }
    }
}
