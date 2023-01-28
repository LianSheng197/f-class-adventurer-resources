using System.Runtime.CompilerServices;

namespace GoogleMobileAds.Api
{
	public class AdapterStatus
	{
		public AdapterState InitializationState
		{
			[CompilerGenerated]
			get
			{
				return default(AdapterState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Description
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

		public int Latency
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal AdapterStatus(AdapterState state, string description, int latency)
		{
		}
	}
}
