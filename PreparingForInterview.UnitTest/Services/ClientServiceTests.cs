using Microsoft.AspNetCore.Http;
using Moq;
using PreparingForInterview.Brokers;
using PreparingForInterview.Models;
using PreparingForInterview.Services;
using System.Runtime.CompilerServices;
using Tynamix.ObjectFiller;

namespace PreparingForInterview.UnitTest.Services
{
    public partial class ClientServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IClientService clientService;

        public ClientServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.clientService = 
                new ClientService(this.storageBrokerMock.Object); ;
        }

        private static Filler<Client> CreateClientFiller() =>
            new Filler<Client>();

        private static Client CreateRandomClient() =>
            CreateClientFiller().Create();
    }
}
