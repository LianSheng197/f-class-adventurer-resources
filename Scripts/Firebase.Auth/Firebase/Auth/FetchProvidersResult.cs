using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	internal sealed class FetchProvidersResult : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		public IEnumerable<string> Providers => null;

		internal FetchProvidersResult(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FetchProvidersResult obj)
		{
			return default(HandleRef);
		}

		~FetchProvidersResult()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public FetchProvidersResult()
		{
		}
	}
}
