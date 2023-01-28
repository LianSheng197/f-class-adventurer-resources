using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace UniRx
{
	public class WWWErrorException : Exception
	{
		public string RawErrorMessage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasResponse
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HttpStatusCode StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(HttpStatusCode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<string, string> ResponseHeaders
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnityWebRequest WWW
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WWWErrorException(UnityWebRequest www, string text)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
