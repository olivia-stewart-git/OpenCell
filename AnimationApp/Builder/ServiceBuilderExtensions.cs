using AnimationApp.Service.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationApp.Builder
{
    static class ServiceBuilderExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<INavigationService, NavigationService>();

            
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterRoutes(this MauiAppBuilder mauiAppBuilder)
        {
            Routes.RegisterRoutes();
            return mauiAppBuilder;
        }
    }
}
