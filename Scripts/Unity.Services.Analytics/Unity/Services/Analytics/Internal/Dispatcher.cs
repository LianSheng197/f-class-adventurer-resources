using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal class Dispatcher : IDispatcher
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CFlush_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Dispatcher _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public Dispatcher _003C_003E4__this;

			public List<Buffer.Token> tokens;

			public IWebRequest request;

			public Guid requestId;

			internal byte[] _003CFlushBufferToService_003Eb__0()
			{
				return null;
			}

			internal void _003CFlushBufferToService_003Eb__1(long responseCode)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CFlushBufferToService_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Dispatcher _003C_003E4__this;

			private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

			private TaskAwaiter<byte[]> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private readonly IBuffer m_DataBuffer;

		private readonly IWebRequestHelper m_WebRequestHelper;

		internal readonly Dictionary<Guid, List<Buffer.Token>> Requests;

		public string CollectUrl
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

		private IConsentTracker ConsentTracker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dispatcher(IBuffer buffer, IWebRequestHelper webRequestHelper, IConsentTracker consentTracker = null)
		{
		}

		[AsyncStateMachine(typeof(_003CFlush_003Ed__11))]
		public Task Flush()
		{
			return null;
		}

		private byte[] SerializeBuffer(List<Buffer.Token> tokens)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFlushBufferToService_003Ed__13))]
		private Task FlushBufferToService()
		{
			return null;
		}
	}
}
