using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	internal class AuthUtilPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_AuthUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_AuthUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			static SWIGExceptionHelper()
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}

			static SWIGPendingException()
			{
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_AuthUtil(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return null;
			}

			static SWIGStringHelper()
			{
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static AuthUtilPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern void UserInfoInterfaceList_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_Add(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint UserInfoInterfaceList_size(HandleRef jarg1);

		[PreserveSig]
		public static extern uint UserInfoInterfaceList_capacity(HandleRef jarg1);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_UserInfoInterfaceList__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_UserInfoInterfaceList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_UserInfoInterfaceList__SWIG_2(int jarg1);

		[PreserveSig]
		public static extern IntPtr UserInfoInterfaceList_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr UserInfoInterfaceList_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr UserInfoInterfaceList_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr UserInfoInterfaceList_Repeat(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void UserInfoInterfaceList_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool UserInfoInterfaceList_Contains(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern int UserInfoInterfaceList_IndexOf(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern int UserInfoInterfaceList_LastIndexOf(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool UserInfoInterfaceList_Remove(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void delete_UserInfoInterfaceList(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_Future_User();

		[PreserveSig]
		public static extern IntPtr Future_User_SWIG_OnCompletion(HandleRef jarg1, Future_User.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_User_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr Future_User_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_User(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_Future_FetchProvidersResult();

		[PreserveSig]
		public static extern IntPtr Future_FetchProvidersResult_SWIG_OnCompletion(HandleRef jarg1, Future_FetchProvidersResult.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_FetchProvidersResult_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr Future_FetchProvidersResult_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_FetchProvidersResult(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_Future_Credential();

		[PreserveSig]
		public static extern IntPtr Future_Credential_SWIG_OnCompletion(HandleRef jarg1, Future_Credential.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_Credential_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr Future_Credential_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_Credential(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_Future_SignInResult();

		[PreserveSig]
		public static extern IntPtr Future_SignInResult_SWIG_OnCompletion(HandleRef jarg1, Future_SignInResult.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_SignInResult_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr Future_SignInResult_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_SignInResult(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_Credential();

		[PreserveSig]
		public static extern void delete_Credential(HandleRef jarg1);

		[PreserveSig]
		public static extern bool Credential_IsValid(HandleRef jarg1);

		[PreserveSig]
		public static extern string Credential_Provider_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr EmailAuthProvider_GetCredential(string jarg1, string jarg2);

		[PreserveSig]
		public static extern string EmailAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_EmailAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FacebookAuthProvider_GetCredential(string jarg1);

		[PreserveSig]
		public static extern string FacebookAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_FacebookAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr GameCenterAuthProvider_GetCredential();

		[PreserveSig]
		public static extern bool GameCenterAuthProvider_IsPlayerAuthenticated();

		[PreserveSig]
		public static extern string GameCenterAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_GameCenterAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr GitHubAuthProvider_GetCredential(string jarg1);

		[PreserveSig]
		public static extern string GitHubAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_GitHubAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr GoogleAuthProvider_GetCredential(string jarg1, string jarg2);

		[PreserveSig]
		public static extern string GoogleAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_GoogleAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern string MicrosoftAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern IntPtr new_MicrosoftAuthProvider();

		[PreserveSig]
		public static extern void delete_MicrosoftAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr OAuthProvider_GetCredential__SWIG_0(string jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr OAuthProvider_GetCredential__SWIG_1(string jarg1, string jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern void delete_OAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern uint PhoneAuthProviderInternal_kMaxTimeoutMs_get();

		[PreserveSig]
		public static extern IntPtr PhoneAuthProviderInternal_GetCredential(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr PhoneAuthProviderInternal_GetInstance(HandleRef jarg1);

		[PreserveSig]
		public static extern string PhoneAuthProviderInternal_ProviderId_get();

		[PreserveSig]
		internal static extern IntPtr PhoneAuthProviderInternal_VerifyPhoneNumberInternal(HandleRef jarg1, string jarg2, uint jarg3, HandleRef jarg4, int jarg5);

		[PreserveSig]
		internal static extern void PhoneAuthProviderInternal_DestroyListenerImplInternal(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void PhoneAuthProviderInternal_SetCallbacks(PhoneAuthProviderInternal.VerificationCompletedDelegate jarg1, PhoneAuthProviderInternal.VerificationFailedDelegate jarg2, PhoneAuthProviderInternal.CodeSentDelegate jarg3, PhoneAuthProviderInternal.TimeOutDelegate jarg4);

		[PreserveSig]
		public static extern void delete_ForceResendingToken(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr PlayGamesAuthProvider_GetCredential(string jarg1);

		[PreserveSig]
		public static extern string PlayGamesAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_PlayGamesAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr TwitterAuthProvider_GetCredential(string jarg1, string jarg2);

		[PreserveSig]
		public static extern string TwitterAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern void delete_TwitterAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern string YahooAuthProvider_ProviderId_get();

		[PreserveSig]
		public static extern IntPtr new_YahooAuthProvider();

		[PreserveSig]
		public static extern void delete_YahooAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern void FederatedProviderData_ProviderId_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string FederatedProviderData_ProviderId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FederatedProviderData();

		[PreserveSig]
		public static extern void delete_FederatedProviderData(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FederatedOAuthProviderData__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_FederatedOAuthProviderData__SWIG_1(string jarg1);

		[PreserveSig]
		public static extern void FederatedOAuthProviderData_Scopes_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FederatedOAuthProviderData_Scopes_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void FederatedOAuthProviderData_CustomParameters_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FederatedOAuthProviderData_CustomParameters_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FederatedOAuthProviderData(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_UserInfoInterface(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_phone_number(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_UserId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_Email_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_DisplayName_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_PhotoUrlInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string UserInfoInterface_ProviderId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string AdditionalUserInfo_ProviderId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string AdditionalUserInfo_UserName_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr AdditionalUserInfo_ProfileInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AdditionalUserInfo_UpdatedCredential_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr AdditionalUserInfo_UpdatedCredential_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_AdditionalUserInfo(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_UserMetadata();

		[PreserveSig]
		public static extern ulong UserMetadata_LastSignInTimestamp_get(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong UserMetadata_CreationTimestamp_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_UserMetadata(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr SignInResult_UserInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr SignInResult_Info_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void SignInResult_Meta_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr SignInResult_Meta_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_SignInResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FirebaseUser(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Token(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_UpdateEmail(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_UpdatePassword(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Reauthenticate(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_ReauthenticateAndRetrieveData(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseUser_ReauthenticateWithProviderInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_SendEmailVerification(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_UpdateUserProfile(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_LinkWithCredential(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_LinkAndRetrieveDataWithCredential(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseUser_LinkWithProviderInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Unlink(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_UpdatePhoneNumberCredential(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Reload(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Delete(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_DisplayName_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_Email_get(HandleRef jarg1);

		[PreserveSig]
		public static extern bool FirebaseUser_IsAnonymous_get(HandleRef jarg1);

		[PreserveSig]
		public static extern bool FirebaseUser_IsEmailVerified_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_Metadata_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_PhoneNumber_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_PhotoUrlInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_ProviderData_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_ProviderId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseUser_UserId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_UserProfile();

		[PreserveSig]
		public static extern void UserProfile_DisplayName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string UserProfile_DisplayName_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void UserProfile_PhotoUrlInternal_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string UserProfile_PhotoUrlInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_UserProfile(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FirebaseAuth(HandleRef jarg1);

		[PreserveSig]
		internal static extern string FirebaseAuth_LanguageCodeInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseAuth_SetLanguageCodeInternal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void FirebaseAuth_UseAppLanguage(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_FetchProvidersForEmailInternal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInWithCustomTokenInternal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInWithCredentialInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInWithProviderInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInAndRetrieveDataWithCredentialInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInAnonymouslyInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_SignInWithEmailAndPasswordInternal(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_CreateUserWithEmailAndPasswordInternal(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void FirebaseAuth_SignOut(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseAuth_SendPasswordResetEmail(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseAuth_GetAuthInternal(HandleRef jarg1, out int jarg2);

		[PreserveSig]
		internal static extern void FirebaseAuth_LogHeartbeatInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseAuth_ReleaseReferenceInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseAuth_CurrentUserInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FetchProvidersResult_Providers_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FetchProvidersResult();

		[PreserveSig]
		public static extern void delete_FetchProvidersResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FederatedAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FederatedOAuthProvider__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_FederatedOAuthProvider__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FederatedOAuthProvider(HandleRef jarg1);

		[PreserveSig]
		public static extern void FederatedOAuthProvider_SetProviderData(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr CreateAuthStateListener(HandleRef jarg1, FirebaseAuth.StateChangedDelegate jarg2);

		[PreserveSig]
		public static extern void DestroyAuthStateListener(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr CreateIdTokenListener(HandleRef jarg1, FirebaseAuth.StateChangedDelegate jarg2);

		[PreserveSig]
		public static extern void DestroyIdTokenListener(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern IntPtr Future_User_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr Future_FetchProvidersResult_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr Future_Credential_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr Future_SignInResult_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr FederatedOAuthProviderData_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseUser_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr FederatedOAuthProvider_SWIGUpcast(IntPtr jarg1);
	}
}
