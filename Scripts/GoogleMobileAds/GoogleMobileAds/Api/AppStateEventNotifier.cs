using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class AppStateEventNotifier
	{
		private static IAppStateEventClient client;

		public static event Action<AppState> AppStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		static AppStateEventNotifier()
		{
		}
	}
}
