using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	internal class GeoAPI : IGeoAPI
	{
		private class WebRequestTaskWrapper
		{
			private readonly UnityWebRequestAsyncOperation m_AsyncOp;

			public WebRequestTaskWrapper(UnityWebRequest request)
			{
			}

			public TaskAwaiter<UnityWebRequestAsyncOperation> GetAwaiter()
			{
				return default(TaskAwaiter<UnityWebRequestAsyncOperation>);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CMakeRequest_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GeoIPResponse> _003C_003Et__builder;

			public GeoAPI _003C_003E4__this;

			private TaskAwaiter<UnityWebRequestAsyncOperation> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private readonly string m_PrivacyEndpoint;

		[AsyncStateMachine(typeof(_003CMakeRequest_003Ed__1))]
		public Task<GeoIPResponse> MakeRequest()
		{
			return null;
		}
	}
}
