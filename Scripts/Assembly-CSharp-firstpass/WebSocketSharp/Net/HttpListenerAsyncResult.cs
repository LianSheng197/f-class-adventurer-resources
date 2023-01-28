using System;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal class HttpListenerAsyncResult : IAsyncResult
	{
		private AsyncCallback _callback;

		private bool _completed;

		private HttpListenerContext _context;

		private bool _endCalled;

		private Exception _exception;

		private bool _inGet;

		private object _state;

		private object _sync;

		private bool _syncCompleted;

		private ManualResetEvent _waitHandle;

		internal bool EndCalled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool InGet
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public object AsyncState => null;

		public WaitHandle AsyncWaitHandle => null;

		public bool CompletedSynchronously => false;

		public bool IsCompleted => false;

		internal HttpListenerAsyncResult(AsyncCallback callback, object state)
		{
		}

		private static void complete(HttpListenerAsyncResult asyncResult)
		{
		}

		internal void Complete(Exception exception)
		{
		}

		internal void Complete(HttpListenerContext context)
		{
		}

		internal void Complete(HttpListenerContext context, bool syncCompleted)
		{
		}

		internal HttpListenerContext GetContext()
		{
			return null;
		}
	}
}
