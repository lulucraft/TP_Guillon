namespace TP_Guillon.Views
{
    public partial class ListeMateriauPage : ContentPage
    {
        public ListeMateriauPage(ListeMateriauViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Liste des matériaux";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(ListeMateriauViewModel.Title)));
        }
    }
}
