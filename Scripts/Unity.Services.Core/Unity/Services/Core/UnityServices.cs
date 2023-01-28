using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Core
{
	public static class UnityServices
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public InitializationOptions options;

			private TaskAwaiter<object> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		internal static ExternalUserIdProperty ExternalUserIdProperty;

		internal static IUnityServices Instance
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

		internal static TaskCompletionSource<object> InstantiationCompletion
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

		public static ServicesInitializationState State => default(ServicesInitializationState);

		public static string ExternalUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Task InitializeAsync()
		{
			return null;
		}

		[PreserveDependency("CaptureUnityThreadInfo()", "Unity.Services.Core.UnityThreadUtils", "Unity.Services.Core")]
		[PreserveDependency("EnableServicesInitializationAsync()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
		[PreserveDependency("CreateStaticInstance()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__15))]
		[PreserveDependency("Register()", "Unity.Services.Core.Registration.CorePackageInitializer", "Unity.Services.Core.Registration")]
		public static Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}
	}
}
