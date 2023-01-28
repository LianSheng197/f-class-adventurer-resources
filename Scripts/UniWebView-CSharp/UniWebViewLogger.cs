public class UniWebViewLogger
{
	public enum Level
	{
		Verbose = 0,
		Debug = 10,
		Info = 20,
		Critical = 80,
		Off = 99
	}

	private static UniWebViewLogger instance;

	private Level level;

	public Level LogLevel
	{
		get
		{
			return default(Level);
		}
		set
		{
		}
	}

	public static UniWebViewLogger Instance => null;

	private UniWebViewLogger(Level level)
	{
	}

	public void Verbose(string message)
	{
	}

	public void Debug(string message)
	{
	}

	public void Info(string message)
	{
	}

	public void Critical(string message)
	{
	}

	private void Log(Level level, string message)
	{
	}
}
