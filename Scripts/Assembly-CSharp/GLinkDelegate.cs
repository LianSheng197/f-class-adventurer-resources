using System.Runtime.CompilerServices;

public static class GLinkDelegate
{
	public delegate void SdkOpenedDelegate();

	public delegate void SdkClosedDelegate();

	public delegate void SdkCallInGameMenuCode(string InGameMenuCode);

	public static event SdkOpenedDelegate sdkOpenedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event SdkClosedDelegate sdkClosedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event SdkCallInGameMenuCode sdkCallInGameMenuCode
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void _callSdkOpened()
	{
	}

	public static void _callSdkClosed()
	{
	}

	public static void _callSdkInGameMenuCode(string InGameMenuCode)
	{
	}
}
