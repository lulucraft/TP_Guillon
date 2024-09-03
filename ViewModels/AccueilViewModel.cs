namespace TP_Guillon.ViewModels
{
    public partial class AccueilViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        private async Task AfficherMateriauxAsync() => await NavigationService.GoToAsync(nameof(ListeMateriauPage));
        
        [RelayCommand]
        private async Task AfficherTypesAsync() => await NavigationService.GoToAsync(nameof(ListeTypePage));
    }
}
