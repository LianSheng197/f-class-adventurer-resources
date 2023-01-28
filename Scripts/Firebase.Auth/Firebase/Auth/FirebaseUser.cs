using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Auth
{
	public sealed class FirebaseUser : UserInfoInterface
	{
		private HandleRef swigCPtr;

		internal FirebaseAuth authProxy;

		public new Uri PhotoUrl => null;

		public new string DisplayName => null;

		public new string Email => null;

		public bool IsAnonymous => false;

		public bool IsEmailVerified => false;

		public UserMetadata Metadata => null;

		public string PhoneNumber => null;

		internal new string PhotoUrlInternal => null;

		public IEnumerable<IUserInfo> ProviderData => null;

		public new string ProviderId => null;

		public new string UserId => null;

		internal FirebaseUser(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(FirebaseUser obj)
		{
			return default(HandleRef);
		}

		public override void Dispose(bool disposing)
		{
		}

		private void CompleteSignInResultTask(Task<SignInResult> task, TaskCompletionSource<SignInResult> taskCompletionSource)
		{
		}

		public Task<SignInResult> ReauthenticateWithProviderAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		private void ThrowIfNull()
		{
		}

		public Task<SignInResult> LinkWithProviderAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		public Task<string> TokenAsync(bool forceRefresh)
		{
			return null;
		}

		public Task UpdateEmailAsync(string email)
		{
			return null;
		}

		public Task UpdatePasswordAsync(string password)
		{
			return null;
		}

		public Task ReauthenticateAsync(Credential credential)
		{
			return null;
		}

		public Task<SignInResult> ReauthenticateAndRetrieveDataAsync(Credential credential)
		{
			return null;
		}

		internal Task<SignInResult> ReauthenticateWithProviderInternalAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		public Task SendEmailVerificationAsync()
		{
			return null;
		}

		public Task UpdateUserProfileAsync(UserProfile profile)
		{
			return null;
		}

		public Task<FirebaseUser> LinkWithCredentialAsync(Credential credential)
		{
			return null;
		}

		public Task<SignInResult> LinkAndRetrieveDataWithCredentialAsync(Credential credential)
		{
			return null;
		}

		internal Task<SignInResult> LinkWithProviderInternalAsync(FederatedAuthProvider provider)
		{
			return null;
		}

		public Task<FirebaseUser> UnlinkAsync(string provider)
		{
			return null;
		}

		public Task<FirebaseUser> UpdatePhoneNumberCredentialAsync(Credential credential)
		{
			return null;
		}

		public Task ReloadAsync()
		{
			return null;
		}

		public Task DeleteAsync()
		{
			return null;
		}
	}
}
