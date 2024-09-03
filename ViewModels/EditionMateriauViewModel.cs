using TP_Guillon.Context.Models;

namespace TP_Guillon.ViewModels
{
    [QueryProperty(nameof(Materiau), "data")]
    public partial class EditionMateriauViewModel : BaseViewModel
    {
        public EditionMateriauViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : base(dialogService, navigationService)
        {

        }

        [ObservableProperty]
        private Materiau _materiau = new();

        [RelayCommand]
        private async Task EnregistrerAsync()
        {
            if (Materiau.IdMateriau == 0)
            {
                //await DbContext.Materiau.AddAsync(Materiau);
                MateriauService!.UpdateMateriau(Materiau);

            }

            //await DbContext.SaveChangesAsync();
            await NavigationService.GoBackAsync();
        }

        [RelayCommand]
        private async Task AnnulerAsync()
        {
            //DbContext.ChangeTracker.Clear(); // Permet d'oublier les changements
            await NavigationService.GoBackAsync();
        }
    }
}
