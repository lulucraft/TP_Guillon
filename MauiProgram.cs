using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TP_Guillon.Context.Models;

namespace TP_Guillon
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .UseMauiCommunityToolkitMarkup()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                       fonts.AddFont("MaterialDesign-Webfont.ttf", "MaterialDesignIcons");
                       fonts.AddFont("FontAwesome-Solid900.ttf", "FontAwesomeIcons");
                   });

            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<EventsPage>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<SearchPage>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

            builder.Services.AddSingleton<AccueilViewModel>();
            builder.Services.AddSingleton<AccueilPage>();
            builder.Services.AddSingleton<IMateriauService, MateriauService>();
            builder.Services.AddSingleton<ListeMateriauViewModel>();
            builder.Services.AddSingleton<ListeMateriauPage>();
            builder.Services.AddSingleton<EditionMateriauViewModel>();
            builder.Services.AddSingleton<EditionMateriauPage>();
            builder.Services.AddSingleton<IMeubleService, MeubleService>();
            builder.Services.AddSingleton<ListeMeubleViewModel>();
            builder.Services.AddSingleton<ListeMeublePage>();
            builder.Services.AddSingleton<FicheMeubleViewModel>();
            builder.Services.AddSingleton<FicheMeublePage>();
            builder.Services.AddSingleton<ITypeService, TypeService>();
            builder.Services.AddSingleton<ListeTypeViewModel>();
            builder.Services.AddSingleton<ListeTypePage>();

            // Ajouter la configuration des secrets utilisateur
            var configuration = new ConfigurationBuilder()
                .Build();

            builder.Configuration.AddConfiguration(configuration);

            // Configurer le contexte de base de données
            object dbContext = builder.Services.AddDbContext<GuillonLucasContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Enregistrer le service de configuration pour l'injection de dépendances
            builder.Services.AddSingleton<IConfiguration>(configuration);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
