using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Core.Internal;
using UnityEngine;

internal class Ua2CoreInitializeCallback : IInitializablePackage
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CoreRegistry registry;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Register()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__1))]
	public Task Initialize(CoreRegistry registry)
	{
		return null;
	}
}
