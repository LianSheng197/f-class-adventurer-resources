using System.Runtime.CompilerServices;

namespace GoogleMobileAds.Api
{
	public class AdValue
	{
		public enum PrecisionType
		{
			Unknown = 0,
			Estimated = 1,
			PublisherProvided = 2,
			Precise = 3
		}

		public PrecisionType Precision
		{
			[CompilerGenerated]
			get
			{
				return default(PrecisionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public long Value
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string CurrencyCode
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
