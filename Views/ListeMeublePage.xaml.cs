using TP_Guillon.ViewModels;

namespace TP_Guillon.Views
{
    public partial class ListeMeublePage : ContentPage
    {
        public ListeMeublePage(ListeMeubleViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Liste des meubles";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(ListeMeubleViewModel.Title)));
        }
    }
}
