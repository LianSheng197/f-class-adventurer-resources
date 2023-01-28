using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal class ConsentTracker : IConsentTracker
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCheckGeoIP_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GeoIPResponse> _003C_003Et__builder;

			public ConsentTracker _003C_003E4__this;

			private TaskAwaiter<GeoIPResponse> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetGeoIPResponse_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GeoIPResponse> _003C_003Et__builder;

			public ConsentTracker _003C_003E4__this;

			private TaskAwaiter<GeoIPResponse> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private readonly IGeoAPI m_GeoAPI;

		private readonly ICoreStatsHelper m_CoreStatsHelper;

		internal GeoIPResponse response;

		internal const string optInPiplConsentStatusPrefKey = "unity.services.analytics.pipl_consent_status";

		internal const string optOutConsentStatusPrefKey = "unity.services.analytics.consent_status";

		internal ConsentStatus optInPiplConsentStatus
		{
			[CompilerGenerated]
			get
			{
				return default(ConsentStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal ConsentStatus optOutConsentStatus
		{
			[CompilerGenerated]
			get
			{
				return default(ConsentStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Dictionary<string, string> piplHeaders => null;

		public Dictionary<string, string> requiredHeaders => null;

		public ConsentTracker(ICoreStatsHelper coreStatsHelper)
		{
		}

		internal ConsentTracker(IGeoAPI geoApi, ICoreStatsHelper coreStatsHelper)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckGeoIP_003Ed__19))]
		public Task<GeoIPResponse> CheckGeoIP()
		{
			return null;
		}

		public void SetUserConsentStatus(string identifier, bool consentGiven)
		{
		}

		public bool IsGeoIpChecked()
		{
			return false;
		}

		public bool IsConsentGiven()
		{
			return false;
		}

		public bool IsConsentGiven(string identifier)
		{
			return false;
		}

		public bool IsConsentDenied()
		{
			return false;
		}

		public bool IsOptingOutInProgress()
		{
			return false;
		}

		public void BeginOptOutProcess(string identifier)
		{
		}

		public void BeginOptOutProcess()
		{
		}

		public void FinishOptOutProcess()
		{
		}

		public void SetDenyConsentToAll()
		{
		}

		internal void SetOptInPiplConsentStatus(bool consentGiven)
		{
		}

		internal void ReadOptInPiplConsentStatus()
		{
		}

		internal void ReadOptOutConsentStatus()
		{
		}

		[AsyncStateMachine(typeof(_003CGetGeoIPResponse_003Ed__33))]
		internal Task<GeoIPResponse> GetGeoIPResponse()
		{
			return null;
		}

		private void ValidateConsentWasChecked()
		{
		}

		private void ValidateConsentFlow(string identifier)
		{
		}
	}
}
