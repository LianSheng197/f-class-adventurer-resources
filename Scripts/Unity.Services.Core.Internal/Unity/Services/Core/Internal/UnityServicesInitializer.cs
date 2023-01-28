using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal static class UnityServicesInitializer
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CEnableServicesInitializationAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void CreateStaticInstance()
		{
		}

		[AsyncStateMachine(typeof(_003CEnableServicesInitializationAsync_003Ed__1))]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void EnableServicesInitializationAsync()
		{
		}
	}
}
