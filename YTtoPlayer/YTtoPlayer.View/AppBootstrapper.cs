using System.Linq;
using System.Reflection;
using YTtoPlayer.Core.ViewModels;

namespace YTtoPlayer.View {
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;

    public class AppBootstrapper : BootstrapperBase {
        SimpleContainer container;

        public AppBootstrapper() {
            Initialize();
        }

        protected override void Configure()
        {
            this.configureNamespaces();

            container = new SimpleContainer();

            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();
            container.PerRequest<MainViewModel, MainViewModel>();
        }

        private void configureNamespaces()
        {
            var config = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViews = "YTtoPlayer.View.Views",
                DefaultSubNamespaceForViewModels = "YTtoPlayer.Core.ViewModels"
            };

            ViewLocator.ConfigureTypeMappings(config);
            ViewModelLocator.ConfigureTypeMappings(config);
        }

        protected override object GetInstance(Type service, string key) {
            var instance = container.GetInstance(service, key);
            if (instance != null)
                return instance;

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service) {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance) {
            container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e) {
            DisplayRootViewFor<MainViewModel>();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var assemblies = base.SelectAssemblies().ToList();
            assemblies.Add(typeof(MainViewModel).GetTypeInfo().Assembly);

            return assemblies;
        }
    }
}