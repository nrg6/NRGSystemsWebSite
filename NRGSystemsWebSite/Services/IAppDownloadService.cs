namespace NRGSystemsWebSite.Services
{
    public interface IAppDownloadService
    {
        Task<object> GetApp(string url);
    }
}
