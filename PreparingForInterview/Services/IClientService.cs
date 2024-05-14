using PreparingForInterview.Models;

namespace PreparingForInterview.Services
{
    public interface IClientService
    {
        ValueTask<Client> AddClientAsync(Client client);
    }
}
