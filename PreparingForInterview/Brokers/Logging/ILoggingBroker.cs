﻿namespace PreparingForInterview.Brokers.Logging
{
	public interface ILoggingBroker
	{
		void LogError(Exception exception);
		void LogCritical(Exception exception);
	}
}
