using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public sealed class Credential : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		public string Provider => null;

		internal Credential(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(Credential obj)
		{
			return default(HandleRef);
		}

		~Credential()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public Credential()
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
