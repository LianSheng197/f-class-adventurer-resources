using System;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	public class YahooAuthProvider : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static string ProviderId => null;

		internal YahooAuthProvider(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(YahooAuthProvider obj)
		{
			return default(HandleRef);
		}

		~YahooAuthProvider()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public YahooAuthProvider()
		{
		}
	}
}
