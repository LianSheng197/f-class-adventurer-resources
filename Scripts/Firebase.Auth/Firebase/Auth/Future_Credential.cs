using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Auth
{
	internal class Future_Credential : FutureBase
	{
		public delegate void Action();

		internal delegate void SWIG_CompletionDelegate(int index);

		private HandleRef swigCPtr;

		private static Dictionary<int, Action> Callbacks;

		private static int CallbackIndex;

		private static object CallbackLock;

		private IntPtr callbackData;

		private SWIG_CompletionDelegate SWIG_CompletionCB;

		internal Future_Credential(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(Future_Credential obj)
		{
			return default(HandleRef);
		}

		public override void Dispose(bool disposing)
		{
		}

		public static Task<Credential> GetTask(Future_Credential fu)
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

		public Future_Credential()
		{
		}

		internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			return (IntPtr)0;
		}

		public void SWIG_FreeCompletionData(IntPtr data)
		{
		}

		public Credential GetResult()
		{
			return null;
		}
	}
}
