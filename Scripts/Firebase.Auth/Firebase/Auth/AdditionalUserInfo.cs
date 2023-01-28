using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public sealed class AdditionalUserInfo : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		public IDictionary<string, object> Profile => null;

		public string ProviderId => null;

		public string UserName => null;

		internal VariantVariantMap ProfileInternal => null;

		public Credential UpdatedCredential
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal AdditionalUserInfo(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(AdditionalUserInfo obj)
		{
			return default(HandleRef);
		}

		~AdditionalUserInfo()
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
