using Microsoft.Extensions.Logging;
using MultiPlatform.Services;
using Presentation.Shared.Services;

namespace MultiPlatform
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            // Add device-specific services used by the Presentation.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            return builder;
        }
    }
}
