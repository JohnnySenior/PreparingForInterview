﻿
namespace PreparingForInterview.Brokers.Logging
{
	public class LoggingBroker : ILoggingBroker
	{
		private readonly ILogger<LoggingBroker> logger;

		public LoggingBroker(ILogger<LoggingBroker> logger) =>
			this.logger = logger;

		public void LogCritical(Exception exception) =>
			this.logger.LogCritical(exception.Message, exception);

		public void LogError(Exception exception) =>
			this.logger.LogError(exception.Message, exception);
	}
}
