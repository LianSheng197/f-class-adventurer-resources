using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api.Mediation;

namespace GoogleMobileAds.Api
{
	public class AdRequest
	{
		public class Builder
		{
			internal HashSet<string> Keywords
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

			internal Dictionary<string, string> Extras
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

			internal List<MediationExtras> MediationExtras
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

			public Builder AddKeyword(string keyword)
			{
				return null;
			}

			public AdRequest Build()
			{
				return null;
			}

			public Builder AddMediationExtras(MediationExtras extras)
			{
				return null;
			}

			public Builder AddExtra(string key, string value)
			{
				return null;
			}
		}

		public const string TestDeviceSimulator = "SIMULATOR";

		public static string Version
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

		public HashSet<string> Keywords
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

		public Dictionary<string, string> Extras
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

		public List<MediationExtras> MediationExtras
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

		static AdRequest()
		{
		}

		private AdRequest(Builder builder)
		{
		}

		internal static string BuildVersionString(string nativePluginVersion = null)
		{
			return null;
		}
	}
}
