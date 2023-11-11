using AnimationApp.AnimationEditor.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationApp.Service.Navigation
{
    internal class Routes
    {
        public static void RegisterRoutes()
        {
            foreach (var route in RegisteredRoutes())
            {
                Routing.RegisterRoute(route.Item1, route.Item2);
            }
        }

        public static IEnumerable<(string, Type)> RegisteredRoutes()
        {
            yield return (nameof(EditorPage), typeof(EditorPage));
        }
    }
}
