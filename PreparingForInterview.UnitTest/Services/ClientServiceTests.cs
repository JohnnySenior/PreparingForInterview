using System.Linq.Expressions;
using Moq;
using PreparingForInterview.Brokers;
using PreparingForInterview.Brokers.Logging;
using PreparingForInterview.Models;
using PreparingForInterview.Services;
using Tynamix.ObjectFiller;
using Xeptions;

namespace PreparingForInterview.UnitTest.Services
{
	public partial class ClientServiceTests
	{
		private readonly Mock<IStorageBroker> storageBrokerMock;
		private readonly Mock<ILoggingBroker> loggingBrokerMock;
		private readonly IClientService clientService;

		public ClientServiceTests()
		{
			this.storageBrokerMock = new Mock<IStorageBroker>();
			this.loggingBrokerMock = new Mock<ILoggingBroker>();

			this.clientService =
				new ClientService(
					this.storageBrokerMock.Object,
					this.loggingBrokerMock.Object); ;
		}

		private static Filler<Client> CreateClientFiller() =>
			new Filler<Client>();

		private static Client CreateRandomClient() =>
			CreateClientFiller().Create();

		private static Expression<Func<Xeption, bool>> SameExceptionAs(Xeption expectedException) =>
			actualException => actualException.SameExceptionAs(expectedException);

	}
}
