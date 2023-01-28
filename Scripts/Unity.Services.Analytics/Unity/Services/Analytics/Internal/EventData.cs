using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics.Internal
{
	public class EventData
	{
		public Dictionary<string, object> Data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal EventData()
		{
		}

		public void Set(string key, float value)
		{
		}

		public void Set(string key, double value)
		{
		}

		public void Set(string key, bool value)
		{
		}

		public void Set(string key, int value)
		{
		}

		public void Set(string key, object value)
		{
		}

		public void Set(string key, long value)
		{
		}

		public void Set(string key, string value)
		{
		}

		public void AddPlatform()
		{
		}

		public void AddBatteryLoad()
		{
		}

		public void AddConnectionType()
		{
		}

		public void AddUserCountry()
		{
		}

		public void AddBuildGuuid()
		{
		}

		public void AddClientVersion()
		{
		}

		public void AddGameBundleID()
		{
		}

		public void AddStdParamData(string sdkMethod, string uasID)
		{
		}
	}
}
