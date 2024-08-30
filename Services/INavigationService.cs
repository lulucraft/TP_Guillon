namespace TP_Guillon.Services
{
    public interface INavigationService
    {
        Task GoToAsync(string route);
    
        Task GoBackAsync();
    }
}
