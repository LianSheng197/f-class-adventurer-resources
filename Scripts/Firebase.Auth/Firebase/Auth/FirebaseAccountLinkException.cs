using System;
using System.Runtime.CompilerServices;

namespace Firebase.Auth
{
	public sealed class FirebaseAccountLinkException : Exception
	{
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AdditionalUserInfo UserInfo => null;

		private SignInResult Result
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FirebaseAccountLinkException(int errorCode, string message, SignInResult signInResult)
		{
		}
	}
}
