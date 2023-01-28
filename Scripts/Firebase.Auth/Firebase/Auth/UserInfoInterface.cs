using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class UserInfoInterface : IUserInfo, IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Uri PhotoUrl => null;

		public string UserId => null;

		public string Email => null;

		public string DisplayName => null;

		internal string PhotoUrlInternal => null;

		public string ProviderId => null;

		internal UserInfoInterface(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(UserInfoInterface obj)
		{
			return default(HandleRef);
		}

		~UserInfoInterface()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public virtual string phone_number()
		{
			return null;
		}
	}
}
