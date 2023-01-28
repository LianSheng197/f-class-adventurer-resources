using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class MicrosoftAuthProvider : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static string ProviderId => null;

		internal MicrosoftAuthProvider(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(MicrosoftAuthProvider obj)
		{
			return default(HandleRef);
		}

		~MicrosoftAuthProvider()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public MicrosoftAuthProvider()
		{
		}
	}
}
