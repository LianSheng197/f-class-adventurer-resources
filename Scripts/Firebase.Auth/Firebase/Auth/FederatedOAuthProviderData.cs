using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class FederatedOAuthProviderData : FederatedProviderData
	{
		private HandleRef swigCPtr;

		public IEnumerable<string> Scopes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, string> CustomParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal FederatedOAuthProviderData(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(FederatedOAuthProviderData obj)
		{
			return default(HandleRef);
		}

		public override void Dispose(bool disposing)
		{
		}

		public FederatedOAuthProviderData()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public FederatedOAuthProviderData(string provider)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}
	}
}
