using FluentAssertions;
using Force.DeepCloner;
using Moq;
using PreparingForInterview.Models;

namespace PreparingForInterview.UnitTest.Services
{
    public partial class ClientServiceTests
    {
        [Fact]
        public async Task ShouldAddClientAsync()
        {
            // given 
            Client randomClient = CreateRandomClient();
            Client inputClient = randomClient;
            Client persistedClient = inputClient;
            Client expectedClient = persistedClient.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertClientAsync(inputClient))
                    .ReturnsAsync(persistedClient);

            // when
            Client actualClient =
                await this.clientService.AddClientAsync(inputClient);

            // then
            actualClient.Should().BeEquivalentTo(expectedClient);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertClientAsync(inputClient),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
