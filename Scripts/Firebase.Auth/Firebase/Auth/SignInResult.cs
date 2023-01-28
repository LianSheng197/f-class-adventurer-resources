using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public sealed class SignInResult : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		internal FirebaseAuth authProxy;

		public FirebaseUser User => null;

		internal FirebaseUser UserInternal => null;

		public AdditionalUserInfo Info => null;

		public UserMetadata Meta
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal SignInResult(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(SignInResult obj)
		{
			return default(HandleRef);
		}

		~SignInResult()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}
	}
}
