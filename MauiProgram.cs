using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MovilApp.IService;
using MovilApp.Servicios;
using MovilApp.Vistas;

namespace MovilApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>().UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<ClientesPage>();
            builder.Services.AddSingleton<DetalleClientePage>();
            builder.Services.AddSingleton<CompletePage>();
            builder.Services.AddSingleton<ReagendarPage>();
            builder.Services.AddSingleton<CancelPage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<IGeneralAPI, GeneralAPI>();
            builder.Services.AddSingleton<IServiceAppointment, ServiceAppoinment>();
            builder.Services.AddSingleton<IServiceUsers, ServiceUser>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}