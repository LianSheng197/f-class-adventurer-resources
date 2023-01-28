using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public sealed class FederatedOAuthProvider : FederatedAuthProvider
	{
		private HandleRef swigCPtr;

		internal FederatedOAuthProvider(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(FederatedOAuthProvider obj)
		{
			return default(HandleRef);
		}

		public override void Dispose(bool disposing)
		{
		}

		public FederatedOAuthProvider()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public FederatedOAuthProvider(FederatedOAuthProviderData providerData)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public void SetProviderData(FederatedOAuthProviderData providerData)
		{
		}
	}
}
