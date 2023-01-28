using System;
using System.Collections.Generic;

namespace Firebase.Auth
{
	public sealed class PhoneAuthProvider : IDisposable
	{
		public delegate void VerificationCompleted(Credential credential);

		public delegate void VerificationFailed(string error);

		public delegate void CodeSent(string verificationId, ForceResendingToken forceResendingToken);

		public delegate void CodeAutoRetrievalTimeOut(string verificationId);

		private class PhoneAuthDelegates
		{
			public VerificationCompleted verificationCompleted;

			public VerificationFailed verificationFailed;

			public CodeSent codeSent;

			public CodeAutoRetrievalTimeOut timeOut;
		}

		private static int uidGenerator;

		private static Dictionary<int, PhoneAuthDelegates> authCallbacks;

		private Dictionary<int, IntPtr> cppListeners;

		private static PhoneAuthProviderInternal.VerificationCompletedDelegate verificationCompletedDelegate;

		private static PhoneAuthProviderInternal.VerificationFailedDelegate verificationFailedDelegate;

		private static PhoneAuthProviderInternal.CodeSentDelegate codeSentDelegate;

		private static PhoneAuthProviderInternal.TimeOutDelegate timeOutDelegate;

		private static bool callbacksInitialized;

		private PhoneAuthProviderInternal InternalProvider;

		private static Dictionary<FirebaseAuth, PhoneAuthProvider> CachedProviders;

		[Obsolete("PhoneAuthProvider.MaxTimeoutMs is deprecated. This value no longer affects PhoneAuthProvider.VerifyPhoneNumber()")]
		public static uint MaxTimeoutMs => 0u;

		private static int SaveCallbacks(VerificationCompleted verificationCompleted, VerificationFailed verificationFailed, CodeSent codeSent, CodeAutoRetrievalTimeOut timeOut)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(PhoneAuthProviderInternal.VerificationCompletedDelegate))]
		private static void VerificationCompletedHandler(int callbackId, IntPtr credential)
		{
		}

		[MonoPInvokeCallback(typeof(PhoneAuthProviderInternal.VerificationFailedDelegate))]
		private static void VerificationFailedHandler(int callbackId, string error)
		{
		}

		[MonoPInvokeCallback(typeof(PhoneAuthProviderInternal.CodeSentDelegate))]
		private static void CodeSentHandler(int callbackId, string verificationId, IntPtr token)
		{
		}

		[MonoPInvokeCallback(typeof(PhoneAuthProviderInternal.TimeOutDelegate))]
		private static void TimeOutHandler(int callbackId, string verificationId)
		{
		}

		private static void InitializeCallbacks()
		{
		}

		public void VerifyPhoneNumber(string phoneNumber, uint autoVerifyTimeOutMs, ForceResendingToken forceResendingToken, VerificationCompleted verificationCompleted, VerificationFailed verificationFailed)
		{
		}

		public void VerifyPhoneNumber(string phoneNumber, uint autoVerifyTimeOutMs, ForceResendingToken forceResendingToken, VerificationCompleted verificationCompleted, VerificationFailed verificationFailed, CodeSent codeSent)
		{
		}

		public void VerifyPhoneNumber(string phoneNumber, uint autoVerifyTimeOutMs, ForceResendingToken forceResendingToken, VerificationCompleted verificationCompleted, VerificationFailed verificationFailed, CodeAutoRetrievalTimeOut codeAutoRetrievalTimeOut)
		{
		}

		public void VerifyPhoneNumber(string phoneNumber, uint autoVerifyTimeOutMs, ForceResendingToken forceResendingToken, VerificationCompleted verificationCompleted, VerificationFailed verificationFailed, CodeSent codeSent, CodeAutoRetrievalTimeOut codeAutoRetrievalTimeOut)
		{
		}

		internal PhoneAuthProvider(FirebaseAuth auth)
		{
		}

		public void Dispose()
		{
		}

		public static PhoneAuthProvider GetInstance(FirebaseAuth auth)
		{
			return null;
		}

		public Credential GetCredential(string verificationId, string verificationCode)
		{
			return null;
		}
	}
}
