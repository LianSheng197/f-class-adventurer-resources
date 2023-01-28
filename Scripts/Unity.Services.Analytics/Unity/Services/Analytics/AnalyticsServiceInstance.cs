using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using Unity.Services.Analytics.Platform;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics
{
	internal class AnalyticsServiceInstance : IAnalyticsService
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCheckForRequiredConsents_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

			public AnalyticsServiceInstance _003C_003E4__this;

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
		private struct _003CInitialize_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public AnalyticsServiceInstance _003C_003E4__this;

			public ICloudProjectId cloudProjectId;

			public IInstallationId installId;

			public IPlayerId playerId;

			public string environment;

			public string customAnalyticsId;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CInitializeUser_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public AnalyticsServiceInstance _003C_003E4__this;

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
		private struct _003CSetAnalyticsEnabled_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public bool enabled;

			public AnalyticsServiceInstance _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		internal IAnalyticsForgetter analyticsForgetter;

		private const string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v1/projects/{0}/environments/{1}";

		private const string k_ForgetCallingId = "com.unity.services.analytics.Events.OptOut";

		internal IBuffer dataBuffer;

		private int m_BufferLengthAtLastGameRunning;

		internal IDataGenerator dataGenerator;

		private string m_CollectURL;

		private readonly StdCommonParams m_CommonParams;

		private readonly string m_StartUpCallingId;

		internal IIDeviceIdentifiersInternal deviceIdentifiersInternal;

		internal ICoreStatsHelper m_CoreStatsHelper;

		internal IConsentTracker ConsentTracker;

		private readonly TransactionCurrencyConverter converter;

		public string PrivacyUrl => null;

		internal IPlayerId PlayerId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IInstallationId InstallId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ICloudProjectId CloudProjectIdProvider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal string CloudProjectId => null;

		internal string CustomAnalyticsId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IDispatcher dataDispatcher
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

		internal bool ServiceEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string SessionID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[AsyncStateMachine(typeof(_003CCheckForRequiredConsents_003Ed__1))]
		public Task<List<string>> CheckForRequiredConsents()
		{
			return null;
		}

		public void ProvideOptInConsent(string identifier, bool consent)
		{
		}

		public void OptOut()
		{
		}

		private void Revoke()
		{
		}

		internal void RevokeWithForgetEvent()
		{
		}

		internal void ForgetMeEventUploaded()
		{
		}

		internal AnalyticsServiceInstance()
		{
		}

		public void Flush()
		{
		}

		public void RecordInternalEvent(Event eventToRecord)
		{
		}

		internal void SetDependencies(ICloudProjectId cloudProjectId, IInstallationId installId, IPlayerId playerId, string environment, string customAnalyticsId)
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__53))]
		internal Task Initialize(ICloudProjectId cloudProjectId, IInstallationId installId, IPlayerId playerId, string environment, string customAnalyticsId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitializeUser_003Ed__54))]
		private Task InitializeUser()
		{
			return null;
		}

		internal void Startup()
		{
		}

		internal void NewPlayerEvent()
		{
		}

		internal void GameEnded()
		{
		}

		internal void RecordGameRunningIfNecessary()
		{
		}

		internal void InternalTick()
		{
		}

		private void SetVariableCommonParams()
		{
		}

		private void GameEnded(DataGenerator.SessionEndState quitState)
		{
		}

		[AsyncStateMachine(typeof(_003CSetAnalyticsEnabled_003Ed__62))]
		public Task SetAnalyticsEnabled(bool enabled)
		{
			return null;
		}

		public string GetAnalyticsUserID()
		{
			return null;
		}

		public void AcquisitionSource(AcquisitionSourceParameters acquisitionSourceParameters)
		{
		}

		public void AdImpression(AdImpressionParameters adImpressionParameters)
		{
		}

		public void CustomData(string eventName, IDictionary<string, object> eventParams)
		{
		}

		public void Transaction(TransactionParameters transactionParameters)
		{
		}

		public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
		{
			return 0L;
		}

		public void TransactionFailed(TransactionFailedParameters parameters)
		{
		}
	}
}
