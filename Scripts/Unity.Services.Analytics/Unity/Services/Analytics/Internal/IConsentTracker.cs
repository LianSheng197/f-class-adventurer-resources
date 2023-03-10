using System.Collections.Generic;
using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal interface IConsentTracker
	{
		Dictionary<string, string> requiredHeaders { get; }

		Task<GeoIPResponse> CheckGeoIP();

		void SetUserConsentStatus(string key, bool consentGiven);

		void BeginOptOutProcess(string identifier);

		void BeginOptOutProcess();

		void FinishOptOutProcess();

		bool IsGeoIpChecked();

		bool IsConsentGiven(string identifier);

		bool IsConsentGiven();

		bool IsConsentDenied();

		bool IsOptingOutInProgress();

		void SetDenyConsentToAll();
	}
}
