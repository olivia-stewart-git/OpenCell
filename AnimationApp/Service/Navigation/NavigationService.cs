using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationApp.Service.Navigation
{
    class NavigationService : INavigationService
    {
        public void Navigate(string routeName)
        {
            Shell.Current.GoToAsync(routeName, false);
        }
    }
}
