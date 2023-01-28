using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class LoadAdError : AdError
	{
		private ILoadAdErrorClient client;

		public LoadAdError(ILoadAdErrorClient client)
			: base(null)
		{
		}

		public ResponseInfo GetResponseInfo()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
