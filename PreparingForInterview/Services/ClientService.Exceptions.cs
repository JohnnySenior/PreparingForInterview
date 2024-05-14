using PreparingForInterview.Models;
using PreparingForInterview.Models.Exceptions;
using Xeptions;

namespace PreparingForInterview.Services
{
	public partial class ClientService
	{
		public delegate ValueTask<Client> ReturningClientFunction();

		public async ValueTask<Client> TryCatch(ReturningClientFunction returningClientFunction)
		{
			try
			{
				return await returningClientFunction();
			}
			catch (NullClientException nullClientException)
			{
				throw CreateAndLogValidationException(nullClientException);
			}
		}

		private ClientValidationException CreateAndLogValidationException(Xeption exception)
		{
			var clientValidationException = new ClientValidationException(exception);
			this.loggingBroker.LogError(clientValidationException);

			return clientValidationException;
		}
	}
}
