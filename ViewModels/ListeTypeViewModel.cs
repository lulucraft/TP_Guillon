using System.Collections.ObjectModel;
using Type = TP_Guillon.Context.Models.Type;

namespace TP_Guillon.ViewModels
{
    public partial class ListeTypeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Type>? _types = [];

        public ListeTypeViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : base(dialogService, navigationService, materiauService, meubleService, typeService)
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            Types = new ObservableCollection<Type>([.. TypeService!.GetTypes()]);
        }
    }
}
