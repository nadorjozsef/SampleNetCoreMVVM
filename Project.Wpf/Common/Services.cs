using System;

namespace Project.Wpf.Common
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
