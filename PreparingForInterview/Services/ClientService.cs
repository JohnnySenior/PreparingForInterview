using PreparingForInterview.Brokers;
using PreparingForInterview.Models;

namespace PreparingForInterview.Services
{
    public class ClientService : IClientService
    {
        private readonly IStorageBroker storageBroker;

        public ClientService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Client> AddClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
