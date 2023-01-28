using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	internal class PhoneAuthProviderInternal : IDisposable
	{
		public delegate void VerificationCompletedDelegate(int callbackId, IntPtr credential);

		public delegate void VerificationFailedDelegate(int callbackId, string error);

		public delegate void CodeSentDelegate(int callbackId, string verificationId, IntPtr token);

		public delegate void TimeOutDelegate(int callbackId, string verificationId);

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static uint kMaxTimeoutMs => 0u;

		public static string ProviderId => null;

		internal PhoneAuthProviderInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(PhoneAuthProviderInternal obj)
		{
			return default(HandleRef);
		}

		~PhoneAuthProviderInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public Credential GetCredential(string verificationId, string verificationCode)
		{
			return null;
		}

		internal static PhoneAuthProviderInternal GetInstance(FirebaseAuth auth)
		{
			return null;
		}

		internal IntPtr VerifyPhoneNumberInternal(string phone_number, uint auto_verify_time_out_ms, ForceResendingToken token, int callback_id)
		{
			return (IntPtr)0;
		}

		internal void DestroyListenerImplInternal(IntPtr listener)
		{
		}

		public static void SetCallbacks(VerificationCompletedDelegate completedCallback, VerificationFailedDelegate failedCallback, CodeSentDelegate sentCallback, TimeOutDelegate timeOutCallback)
		{
		}
	}
}
