using PreparingForInterview.Models;
using PreparingForInterview.Models.Exceptions;

namespace PreparingForInterview.Services
{
	public partial class ClientService
	{
		public void ClientNotNull(Client client)
		{
			if (client is null)
				throw new NullClientException();
		}
	}
}
