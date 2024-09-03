using TP_Guillon.ViewModels;

namespace TP_Guillon.Views
{
    public partial class ListeTypePage : ContentPage
    {
        public ListeTypePage(ListeTypeViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Liste des types";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(ListeTypeViewModel.Title)));
        }
    }
}
