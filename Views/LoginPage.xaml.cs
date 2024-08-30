namespace TP_Guillon.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Login";
            BindingContext = viewModel;
        }
    }
}
