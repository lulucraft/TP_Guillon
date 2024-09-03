namespace TP_Guillon.Views
{
    public partial class EditionMateriauPage : ContentPage
    {
        public EditionMateriauPage(EditionMateriauViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Edition des matériaux";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(EditionMateriauViewModel.Title)));
        }
    }
}
