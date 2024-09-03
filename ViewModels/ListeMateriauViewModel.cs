using System.Collections.ObjectModel;
using TP_Guillon.Context.Models;

namespace TP_Guillon.ViewModels
{
    public partial class ListeMateriauViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Materiau>? _materiaux = [];

        public ListeMateriauViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : base(dialogService, navigationService, materiauService, meubleService, typeService)
        {
            LoadMateriaux();
        }

        private void LoadMateriaux()
        {
            Materiaux = new ObservableCollection<Materiau>([.. MateriauService!.GetMateriaux()]);
        }

        [RelayCommand]
        private void Actualiser() => LoadMateriaux();

        [RelayCommand]
        private async Task AjouterMateriauAsync() => await NavigationService.GoToAsync(nameof(EditionMateriauPage));

        [RelayCommand]
        private Task EditerMateriauAsync(Materiau materiau) => NavigationService.GoToAsync(nameof(EditionMateriauPage), materiau);
        
        [RelayCommand]
        private async Task SupprimerMateriauAsync(Materiau materiau)
        {
            bool reponse = await DialogService.DisplayAlertAsync("Êtes-vous sûr ?",
                $"Le Materiau « {materiau.Nom} » est sur le point d'être définitivement supprimé", "Supprimer", "Annuler");

            if (reponse)
            {
                try
                {
                    //DbContext.Materiau.Remove(Materiaus);
                    //await DbContext.SaveChangesAsync();
                    MateriauService!.RemoveMateriau(materiau);
                    Materiaux!.Remove(materiau);
                }
                catch (Exception ex)
                {
                    //DbContext.ChangeTracker.Clear(); // Permet d'oublier le fait qu'on souhaite une suppression
                    await DialogService.DisplayAlertAsync("Échec",
                    $"La suppression a échoué ({ex.Message})", "OK");
                }
            }
        }

        [RelayCommand]
        private async Task RetourAsync() => await NavigationService.GoBackAsync();

    }

}