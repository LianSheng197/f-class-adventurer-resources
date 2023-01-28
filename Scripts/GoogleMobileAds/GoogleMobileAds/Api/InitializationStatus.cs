using System.Collections.Generic;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class InitializationStatus
	{
		private IInitializationStatusClient client;

		internal InitializationStatus(IInitializationStatusClient client)
		{
		}

		public AdapterStatus getAdapterStatusForClassName(string className)
		{
			return null;
		}

		public Dictionary<string, AdapterStatus> getAdapterStatusMap()
		{
			return null;
		}
	}
}
