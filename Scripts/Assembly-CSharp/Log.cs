public class Log
{
	public enum EnableMinLevel
	{
		None = 0,
		Normal = 1,
		Warning = 2,
		Error = 3,
		Max = 4
	}

	private static EnableMinLevel _enableMinLevel;

	public static bool IsEnable()
	{
		return false;
	}

	public static void SetEnableMinLevel(EnableMinLevel enableMinLevel)
	{
	}

	public static void Normal(object msg)
	{
	}

	public static void NormalFormat(string format, params object[] args)
	{
	}

	public static void Warning(object msg)
	{
	}

	public static void WarningFormat(string format, params object[] args)
	{
	}

	public static void Error(object msg)
	{
	}

	public static void ErrorFormat(string format, params object[] args)
	{
	}
}
