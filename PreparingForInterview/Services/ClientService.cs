using PreparingForInterview.Brokers;
using PreparingForInterview.Models;
using System.Runtime.InteropServices;

namespace PreparingForInterview.Services
{
    public class ClientService : IClientService
    {
        private readonly IStorageBroker storageBroker;

        public ClientService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Client> AddClientAsync(Client client) =>
            await this.storageBroker.InsertClientAsync(client);
    }
}
