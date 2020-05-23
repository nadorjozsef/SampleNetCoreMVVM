using Microsoft.Extensions.DependencyInjection;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    public class ViewModelLocator
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
