using System;
using System.Runtime.CompilerServices;

namespace GoogleMobileAds.Api
{
	public class AdErrorEventArgs : EventArgs
	{
		public AdError AdError
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

		[Obsolete("use AdError.GetMessage() instead.")]
		public string Message
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
	}
}
