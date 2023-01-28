namespace GoogleMobileAds.Api
{
	public class AdSize
	{
		public enum Type
		{
			Standard = 0,
			SmartBanner = 1,
			AnchoredAdaptive = 2
		}

		private Type type;

		private Orientation orientation;

		private int width;

		private int height;

		public static readonly AdSize Banner;

		public static readonly AdSize MediumRectangle;

		public static readonly AdSize IABBanner;

		public static readonly AdSize Leaderboard;

		public static readonly AdSize SmartBanner;

		public static readonly int FullWidth;

		public int Width => 0;

		public int Height => 0;

		public Type AdType => default(Type);

		internal Orientation Orientation => default(Orientation);

		public AdSize(int width, int height)
		{
		}

		private AdSize(int width, int height, Type type)
		{
		}

		private static AdSize CreateAnchoredAdaptiveAdSize(int width, Orientation orientation)
		{
			return null;
		}

		public static AdSize GetLandscapeAnchoredAdaptiveBannerAdSizeWithWidth(int width)
		{
			return null;
		}

		public static AdSize GetPortraitAnchoredAdaptiveBannerAdSizeWithWidth(int width)
		{
			return null;
		}

		public static AdSize GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(int width)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(AdSize a, AdSize b)
		{
			return false;
		}

		public static bool operator !=(AdSize a, AdSize b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
