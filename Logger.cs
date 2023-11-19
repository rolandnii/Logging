
namespace Logging
{
	  class Logger
	{
		public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

		public void LogMessage(LogLevel level, string msg)
		{
			if (EnabledLevel < level) return;
            Console.WriteLine(msg);
        }
	}

	 enum LogLevel 
	{
		Off, 
		Critical,
		Error,
		Warning,
		Information,
		Trace,
	}
}
