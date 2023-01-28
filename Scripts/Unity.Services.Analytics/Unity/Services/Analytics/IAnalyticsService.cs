using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics
{
	public interface IAnalyticsService
	{
		string PrivacyUrl { get; }

		string SessionID { get; }

		void Flush();

		void AdImpression(AdImpressionParameters parameters);

		void Transaction(TransactionParameters transactionParameters);

		void TransactionFailed(TransactionFailedParameters parameters);

		void CustomData(string eventName, IDictionary<string, object> eventParams);

		Task<List<string>> CheckForRequiredConsents();

		void ProvideOptInConsent(string identifier, bool consent);

		void OptOut();

		void RecordInternalEvent(Event eventToRecord);

		void AcquisitionSource(AcquisitionSourceParameters acquisitionSourceParameters);

		Task SetAnalyticsEnabled(bool enabled);

		long ConvertCurrencyToMinorUnits(string currencyCode, double value);

		string GetAnalyticsUserID();
	}
}
