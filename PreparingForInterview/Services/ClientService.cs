using PreparingForInterview.Brokers;
using PreparingForInterview.Brokers.Logging;
using PreparingForInterview.Models;

namespace PreparingForInterview.Services
{
	public partial class ClientService : IClientService
	{
		private readonly IStorageBroker storageBroker;
		private readonly ILoggingBroker loggingBroker;

		public ClientService(IStorageBroker storageBroker, ILoggingBroker loggingBroker)
		{
			this.storageBroker = storageBroker;
			this.loggingBroker = loggingBroker;
		}

		public ValueTask<Client> AddClientAsync(Client client) =>
		TryCatch(async () =>
		{
			ClientNotNull(client);
			return await this.storageBroker.InsertClientAsync(client);
		});
	}
}
