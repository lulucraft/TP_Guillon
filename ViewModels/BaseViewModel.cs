namespace TP_Guillon.ViewModels
{
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        public IMateriauService? MateriauService;

        public IMeubleService? MeubleService;

        public ITypeService? TypeService;

        [ObservableProperty]
        private string _title = string.Empty;

        public BaseViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : this(dialogService, navigationService)
        {
            MateriauService = materiauService;
            MeubleService = meubleService;
            TypeService = typeService;
        }
    }
}
