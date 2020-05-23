using System;

namespace WpfApp1
{
    public static class Services
    {
        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public static IServiceProvider ServiceProvider { get; private set; }
    }

}
