using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public sealed class UserProfile : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		public Uri PhotoUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DisplayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string PhotoUrlInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal UserProfile(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(UserProfile obj)
		{
			return default(HandleRef);
		}

		~UserProfile()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public UserProfile()
		{
		}
	}
}
