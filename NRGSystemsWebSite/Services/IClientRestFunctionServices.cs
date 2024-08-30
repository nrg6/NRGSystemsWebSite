using NRGsystemsProgrammer.Models;

namespace NRGsystemsProgrammer.Services;
public interface IClientRestFunctionServices
{
    Task<Clients> Login(string userName, string password);
    // CLIENTS
    Task<bool> CreateAClient(Clients client);
    Task<List<Clients>> GetAllClients();
    Task<Clients> GetAClient(int clientsId);
    Task<string> DeleteAClient(int clientsId);
    Task<string> EditAClient(Clients client);
}
