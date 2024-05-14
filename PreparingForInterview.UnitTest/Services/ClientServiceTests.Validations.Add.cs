using FluentAssertions;
using Moq;
using PreparingForInterview.Models;
using PreparingForInterview.Models.Exceptions;

namespace PreparingForInterview.UnitTest.Services
{
	public partial class ClientServiceTests
	{
		[Fact]
		public async Task ShouldThrowValidationExceptionOnAddClientIfClientIsNullAsync()
		{
			// given
			Client nullClient = null;
			var nullClientException = new NullClientException();

			var expectedClientValidationException =
				new ClientValidationException(nullClientException);

			// when
			ValueTask<Client> addClientTask =
				this.clientService.AddClientAsync(nullClient);

			ClientValidationException actualClientValidationException =
				await Assert.ThrowsAsync<ClientValidationException>(addClientTask.AsTask);

			// then
			actualClientValidationException.Should().BeEquivalentTo(expectedClientValidationException);

			this.loggingBrokerMock.Verify(broker =>
				broker.LogError(It.Is(SameExceptionAs(
					expectedClientValidationException))), Times.Once);

			this.storageBrokerMock.Verify(broker =>
				broker.InsertClientAsync(nullClient), Times.Never);

			this.loggingBrokerMock.VerifyNoOtherCalls();
			this.storageBrokerMock.VerifyNoOtherCalls();
		}
	}
}
