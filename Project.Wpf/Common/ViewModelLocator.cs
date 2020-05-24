using Microsoft.Extensions.DependencyInjection;
using Project.Wpf.ViewModels;

namespace Project.Wpf.Common
{
    internal sealed class ViewModelLocator
    {
        public ViewModelLocator()
        { }

        public IMainViewModel MainViewModel
        {
            get
            {
                return Services.ServiceProvider.GetRequiredService<IMainViewModel>();
            }
        }
    }
}
