namespace YTtoPlayer.View.Configuration
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Windows;

    using Caliburn.Micro;

    using YTtoPlayer.Core.ViewModels;

    public class DefaultBootstrapper : BootstrapperBase
    {
        public DefaultBootstrapper()
        {
            this.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            this.DisplayRootViewFor<MainViewModel>();
            base.OnStartup(sender, e);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var assemblies = base.SelectAssemblies().ToList();
            assemblies.Add(typeof(MainViewModel).GetTypeInfo().Assembly);

            return assemblies;
        }
    }
}