using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class FederatedProviderData : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string ProviderId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal FederatedProviderData(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FederatedProviderData obj)
		{
			return default(HandleRef);
		}

		~FederatedProviderData()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public FederatedProviderData()
		{
		}
	}
}
