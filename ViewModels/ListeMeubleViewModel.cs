using System.Collections.ObjectModel;
using TP_Guillon.Context.Models;

namespace TP_Guillon.ViewModels
{
    public partial class ListeMeubleViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Meuble>? _meubles = [];

        public ListeMeubleViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : base(dialogService, navigationService, materiauService, meubleService, typeService)
        {
            LoadMeubles();
        }

        private void LoadMeubles()
        {
            Meubles = new ObservableCollection<Meuble>([.. MeubleService!.GetMeubles()]);
        }

        [RelayCommand]
        private async Task RetourAsync() => await NavigationService.GoBackAsync();
    }
}
