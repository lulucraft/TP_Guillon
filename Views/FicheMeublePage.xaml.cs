using TP_Guillon.ViewModels;

namespace TP_Guillon.Views
{
    public partial class FicheMeublePage : ContentPage
    {
        public FicheMeublePage(FicheMeubleViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Fiche des meuble";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(FicheMeubleViewModel.Title)));
        }
    }
}
