using Xeptions;

namespace PreparingForInterview.Models.Exceptions
{
	public class NullClientException : Xeption
	{
		public NullClientException()
			: base(message: "Client is null")
		{ }
	}
}
