using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using Newtonsoft.Json;
using YTtoPlayer.Core.Resources;
using YTtoPlayer.Core.ViewModels;
using YTtoPlayer.View.Helpers;

namespace YTtoPlayer.View.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
            Settings settings = this.LoadSettings();
            this.DataContext = new MainViewModel(settings, new WpfLocationPicker());
        }

        private Settings LoadSettings()
        {
            string baseDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filePath = Path.Combine(baseDirectory, "ytconfig.json");

            using (var streamReader = new StreamReader(filePath))
            {
                string settingsJson = streamReader.ReadToEnd();
                Settings settings = JsonConvert.DeserializeObject<Settings>(settingsJson);
                return settings;
            }
        }
    }
}
