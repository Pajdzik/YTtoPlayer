namespace YTtoPlayer.View
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows;

    using Caliburn.Micro;

    using YTtoPlayer.Core.ViewModels;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.ConfigureCaliburnMicro();
        }

        private void ConfigureCaliburnMicro()
        {
            var config = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViews = "View.Views",
                DefaultSubNamespaceForViewModels = "Core.ViewModels"
            };

            ViewLocator.ConfigureTypeMappings(config);
            ViewModelLocator.ConfigureTypeMappings(config);
        }

    }
}