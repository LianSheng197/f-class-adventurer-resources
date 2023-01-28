using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	internal class ResponseInfoClient : IResponseInfoClient
	{
		private AndroidJavaObject androidResponseInfo;

		public ResponseInfoClient(ResponseInfoClientType type, AndroidJavaObject androidJavaObject)
		{
		}

		public string GetMediationAdapterClassName()
		{
			return null;
		}

		public string GetResponseId()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
