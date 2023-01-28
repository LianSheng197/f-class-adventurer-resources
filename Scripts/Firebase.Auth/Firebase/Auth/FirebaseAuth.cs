using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Auth
{
	public sealed class FirebaseAuth : IDisposable
	{
		internal delegate void StateChangedDelegate(IntPtr authCPtr);

		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		private FirebaseApp appProxy;

		private IntPtr appCPtr;

		private IntPtr authStateListener;

		private IntPtr idTokenListener;

		private FirebaseUser currentUser;

		private bool persistentLoaded;

		private static Dictionary<IntPtr, FirebaseAuth> appCPtrToAuth;

		public string LanguageCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static FirebaseAuth DefaultInstance => null;

		public FirebaseApp App => null;

		public FirebaseUser CurrentUser => null;

		internal FirebaseUser CurrentUserInternal => null;

		public event EventHandler StateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		private event EventHandler stateChangedImpl
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler IdTokenChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		private event EventHandler idTokenChangedImpl
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal FirebaseAuth(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseAuth obj)
		{
			return default(HandleRef);
		}

		~FirebaseAuth()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public Task<SignInResult> SignInWithProviderAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		private static FirebaseAuth ProxyFromAppCPtr(IntPtr appCPtr)
		{
			return null;
		}

		private void ThrowIfNull()
		{
		}

		public static FirebaseAuth GetAuth(FirebaseApp app)
		{
			return null;
		}

		private void OnAppDisposed(object sender, EventArgs eventArgs)
		{
		}

		private void DisposeInternal()
		{
		}

		private static void ForwardStateChange(IntPtr appCPtr, Action<FirebaseAuth> stateChangeClosure)
		{
		}

		[MonoPInvokeCallback(typeof(StateChangedDelegate))]
		internal static void StateChangedFunction(IntPtr appCPtr)
		{
		}

		[MonoPInvokeCallback(typeof(StateChangedDelegate))]
		internal static void IdTokenChangedFunction(IntPtr appCPtr)
		{
		}

		public Task<IEnumerable<string>> FetchProvidersForEmailAsync(string email)
		{
			return null;
		}

		private FirebaseUser UpdateCurrentUser(FirebaseUser proxy)
		{
			return null;
		}

		public Task<FirebaseUser> SignInWithCustomTokenAsync(string token)
		{
			return null;
		}

		public Task<FirebaseUser> SignInWithCredentialAsync(Credential credential)
		{
			return null;
		}

		public Task<SignInResult> SignInAndRetrieveDataWithCredentialAsync(Credential credential)
		{
			return null;
		}

		public Task<FirebaseUser> SignInAnonymouslyAsync()
		{
			return null;
		}

		public Task<FirebaseUser> SignInWithEmailAndPasswordAsync(string email, string password)
		{
			return null;
		}

		public Task<FirebaseUser> CreateUserWithEmailAndPasswordAsync(string email, string password)
		{
			return null;
		}

		private void CompleteFirebaseUserTask(Task<FirebaseUser> task, TaskCompletionSource<FirebaseUser> taskCompletionSource)
		{
		}

		private void CompleteSignInResultTask(Task<SignInResult> task, TaskCompletionSource<SignInResult> taskCompletionSource)
		{
		}

		internal string LanguageCodeInternal()
		{
			return null;
		}

		internal void SetLanguageCodeInternal(string LanguageCodeInternal)
		{
		}

		public void UseAppLanguage()
		{
		}

		internal Task<FetchProvidersResult> FetchProvidersForEmailInternalAsync(string email)
		{
			return null;
		}

		internal Task<FirebaseUser> SignInWithCustomTokenInternalAsync(string token)
		{
			return null;
		}

		internal Task<FirebaseUser> SignInWithCredentialInternalAsync(Credential credential)
		{
			return null;
		}

		internal Task<SignInResult> SignInWithProviderInternalAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		internal Task<SignInResult> SignInAndRetrieveDataWithCredentialInternalAsync(Credential credential)
		{
			return null;
		}

		internal Task<FirebaseUser> SignInAnonymouslyInternalAsync()
		{
			return null;
		}

		internal Task<FirebaseUser> SignInWithEmailAndPasswordInternalAsync(string email, string password)
		{
			return null;
		}

		internal Task<FirebaseUser> CreateUserWithEmailAndPasswordInternalAsync(string email, string password)
		{
			return null;
		}

		public void SignOut()
		{
		}

		public Task SendPasswordResetEmailAsync(string email)
		{
			return null;
		}

		internal static FirebaseAuth GetAuthInternal(FirebaseApp app, out InitResult init_result_out)
		{
			init_result_out = default(InitResult);
			return null;
		}

		internal static void LogHeartbeatInternal(FirebaseApp app)
		{
		}

		internal static void ReleaseReferenceInternal(FirebaseAuth instance)
		{
		}
	}
}
