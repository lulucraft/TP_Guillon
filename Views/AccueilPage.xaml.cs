namespace TP_Guillon.Views
{
    public partial class AccueilPage : ContentPage
    {
        public AccueilPage(AccueilViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Accueil";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(AccueilViewModel.Title)));
        }
    }
}
