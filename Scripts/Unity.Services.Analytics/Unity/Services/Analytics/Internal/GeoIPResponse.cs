using System;

namespace Unity.Services.Analytics.Internal
{
	[Serializable]
	internal class GeoIPResponse
	{
		public string identifier;

		public string country;

		public string region;

		public int ageGateLimit;
	}
}
