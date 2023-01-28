using System;
using SRDebugger.Services;

public static class SRDebug
{
	public const string Version = "1.11.0";

	public static Action<ConsoleEntry> CopyConsoleItemCallback;

	public static IDebugService Instance => null;

	public static void Init()
	{
	}

	public static Action<ConsoleEntry> GetDefaultCopyConsoleItemCallback()
	{
		return null;
	}
}
