namespace MathNet.Numerics
{
	public static class AppSwitches
	{
		private const string AppSwitchDisableNativeProviderProbing = "Switch.MathNet.Numerics.Providers.DisableNativeProviderProbing";

		private const string AppSwitchDisableNativeProviders = "Switch.MathNet.Numerics.Providers.DisableNativeProviders";

		private const string AppSwitchDisableMklNativeProvider = "Switch.MathNet.Numerics.Providers.DisableMklNativeProvider";

		private const string AppSwitchDisableCudaNativeProvider = "Switch.MathNet.Numerics.Providers.DisableCudaNativeProvider";

		private const string AppSwitchDisableOpenBlasNativeProvider = "Switch.MathNet.Numerics.Providers.DisableOpenBlasNativeProvider";

		public static bool DisableNativeProviderProbing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool DisableNativeProviders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool DisableMklNativeProvider
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool DisableCudaNativeProvider
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool DisableOpenBlasNativeProvider
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static void SetSwitch(string switchName, bool isEnabled)
		{
		}

		private static bool IsEnabled(string switchName)
		{
			return false;
		}
	}
}
