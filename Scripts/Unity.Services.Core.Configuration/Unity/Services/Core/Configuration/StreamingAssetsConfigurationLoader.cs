using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
	internal class StreamingAssetsConfigurationLoader : IConfigurationLoader
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetConfigAsync_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SerializableProjectConfiguration> _003C_003Et__builder;

			private TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[AsyncStateMachine(typeof(_003CGetConfigAsync_003Ed__0))]
		public Task<SerializableProjectConfiguration> GetConfigAsync()
		{
			return null;
		}
	}
}
