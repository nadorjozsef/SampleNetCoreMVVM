using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Project.Wpf.Common;
using Project.Wpf.ViewModels;

namespace Project.Wpf
{
    public partial class App : Application
    {
        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Services.SetServiceProvider(serviceProvider);
        }

        private static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMainViewModel, MainViewModel>();
        }
    }
}
