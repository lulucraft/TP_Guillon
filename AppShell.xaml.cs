namespace TP_Guillon
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            AppShell.RegisterRoutes();
        }

        private static void RegisterRoutes()
        {
            //Routing.RegisterRoute("affichermateriau", typeof(EditionMateriauPage));
            Routing.RegisterRoute(nameof(ListeMateriauPage), typeof(ListeMateriauPage));
            Routing.RegisterRoute(nameof(EditionMateriauPage), typeof(EditionMateriauPage));
            Routing.RegisterRoute(nameof(ListeTypePage), typeof(ListeTypePage));
            Routing.RegisterRoute(nameof(EditionTypePage), typeof(EditionTypePage));
            Routing.RegisterRoute(nameof(ListeMeublePage), typeof(ListeMeublePage));
            Routing.RegisterRoute(nameof(FicheMeublePage), typeof(FicheMeublePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}
