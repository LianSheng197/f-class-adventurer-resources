using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class UserMetadata : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public ulong LastSignInTimestamp => 0uL;

		public ulong CreationTimestamp => 0uL;

		internal UserMetadata(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(UserMetadata obj)
		{
			return default(HandleRef);
		}

		~UserMetadata()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public UserMetadata()
		{
		}
	}
}
