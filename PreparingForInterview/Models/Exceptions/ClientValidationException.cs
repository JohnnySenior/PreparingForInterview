using Xeptions;

namespace PreparingForInterview.Models.Exceptions
{
	public class ClientValidationException : Xeption
	{
		public ClientValidationException(Xeption innerException)
			: base(message: "Client validation error occurred, fix the error and try again", innerException)
		{ }
	}
}
