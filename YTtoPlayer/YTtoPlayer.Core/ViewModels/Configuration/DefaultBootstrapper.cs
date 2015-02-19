namespace YTtoPlayer.Core.ViewModels.Configuration
{
    using System.Windows;

    using Caliburn.Micro;

    internal class DefaultBootstrapper : BootstrapperBase
    {
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            this.DisplayRootViewFor<MainViewModel>();
            base.OnStartup(sender, e);
        }
    }
}