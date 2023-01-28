using System;

namespace Firebase.Auth
{
	internal sealed class AuthUtil
	{
		public static void ExportFix()
		{
		}

		internal static IntPtr CreateAuthStateListener(FirebaseAuth auth, FirebaseAuth.StateChangedDelegate state_changed_delegate)
		{
			return (IntPtr)0;
		}

		internal static void DestroyAuthStateListener(FirebaseAuth auth, IntPtr listener)
		{
		}

		internal static IntPtr CreateIdTokenListener(FirebaseAuth auth, FirebaseAuth.StateChangedDelegate state_changed_delegate)
		{
			return (IntPtr)0;
		}

		internal static void DestroyIdTokenListener(FirebaseAuth auth, IntPtr listener)
		{
		}
	}
}
