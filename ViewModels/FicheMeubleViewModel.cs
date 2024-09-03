using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using TP_Guillon.Context.Models;

namespace TP_Guillon.ViewModels
{
    [QueryProperty(nameof(Meuble), "data")]
    public partial class FicheMeubleViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : BaseViewModel(dialogService, navigationService, materiauService, meubleService, typeService)
    {
        [ObservableProperty]
        private Meuble _meuble = new();

        [RelayCommand]
        private Task RetourAsync() => NavigationService.GoBackAsync();
    }
}
