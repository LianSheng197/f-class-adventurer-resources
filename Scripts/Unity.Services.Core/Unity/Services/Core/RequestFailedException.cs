using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core
{
	public class RequestFailedException : Exception
	{
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public RequestFailedException(int errorCode, string message)
		{
		}

		public RequestFailedException(int errorCode, string message, Exception innerException)
		{
		}
	}
}
