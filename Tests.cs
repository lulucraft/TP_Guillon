using Microsoft.Playwright;

namespace TP_Guillon
{
    public class Tests
    {
        protected IPlaywright? Playwrightt { get; private set; }
        protected Microsoft.Playwright.IBrowser? Browser { get; private set; }
        protected IBrowserContext? BrowserContext { get; private set; }
        protected IPage? Page { get; private set; }

        private async Task InitializePlaywright()
        {
            Playwrightt = await Playwright.CreateAsync();
            InitializePlaywright().GetAwaiter().GetResult();
            Browser = await Playwrightt.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            BrowserContext = await Browser.NewContextAsync();
            Page = await BrowserContext.NewPageAsync();
        }

        public async Task DisposeAsync()
        {
            await Browser!.CloseAsync();
            Playwrightt!.Dispose();
        }
    }

    internal class Claculatrice
    {
        public int Ajouter(int premiereValeur, int secondeValeur)
        {
            return premiereValeur + secondeValeur;
        }

        public int ObtenirAge(DateTime dateAnniversaire, DateTime dateCible)
        {
            int age = dateCible.Year - dateAnniversaire.Year;

            // Si l'anniversaire n'est pas encore passé cette année
            if (dateCible < dateAnniversaire.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }

}
