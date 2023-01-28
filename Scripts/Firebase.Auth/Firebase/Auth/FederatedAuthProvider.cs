using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class FederatedAuthProvider : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal FederatedAuthProvider(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FederatedAuthProvider obj)
		{
			return default(HandleRef);
		}

		~FederatedAuthProvider()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}
	}
}
