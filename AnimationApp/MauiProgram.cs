using AnimationApp.Builder;

namespace AnimationApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var app = MauiApp.CreateBuilder()
                        .UseMauiApp<App>()
                        .ConfigureFonts(fonts =>
                        {
                            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                        })
                        .RegisterServices()
                        .RegisterRoutes()
                        .Build();

            ServiceHelper.Initialize(app.Services);

            return app;
        }
    }
}