using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using TP_Guillon.Context.Models;

namespace TP_Guillon.ViewModels
{
    [QueryProperty(nameof(Context.Models.Type), "data")]
    public partial class EditionTypeViewModel(IDialogService dialogService, INavigationService navigationService, IMateriauService materiauService, IMeubleService meubleService, ITypeService typeService) : BaseViewModel(dialogService, navigationService, materiauService, meubleService, typeService)
    {

    }
}
