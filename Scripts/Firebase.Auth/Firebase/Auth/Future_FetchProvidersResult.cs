using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Auth
{
	internal class Future_FetchProvidersResult : FutureBase
	{
		public delegate void Action();

		internal delegate void SWIG_CompletionDelegate(int index);

		private HandleRef swigCPtr;

		private static Dictionary<int, Action> Callbacks;

		private static int CallbackIndex;

		private static object CallbackLock;

		private IntPtr callbackData;

		private SWIG_CompletionDelegate SWIG_CompletionCB;

		internal Future_FetchProvidersResult(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(Future_FetchProvidersResult obj)
		{
			return default(HandleRef);
		}

		public override void Dispose(bool disposing)
		{
		}

		public static Task<FetchProvidersResult> GetTask(Future_FetchProvidersResult fu)
		{
			return null;
		}

		private void ThrowIfDisposed()
		{
		}

		public void SetOnCompletionCallback(Action userCompletionCallback)
		{
		}

		private void SetCompletionData(IntPtr data)
		{
		}

		[MonoPInvokeCallback(typeof(SWIG_CompletionDelegate))]
		private static void SWIG_CompletionDispatcher(int key)
		{
		}

		public Future_FetchProvidersResult()
		{
		}

		internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			return (IntPtr)0;
		}

		public void SWIG_FreeCompletionData(IntPtr data)
		{
		}

		public FetchProvidersResult GetResult()
		{
			return null;
		}
	}
}
