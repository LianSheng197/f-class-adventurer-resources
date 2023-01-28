using System.Collections.Specialized;

namespace WebSocketSharp.Net
{
	internal abstract class AuthenticationBase
	{
		private AuthenticationSchemes _scheme;

		internal NameValueCollection Parameters;

		public string Algorithm => null;

		public string Nonce => null;

		public string Opaque => null;

		public string Qop => null;

		public string Realm => null;

		public AuthenticationSchemes Scheme => default(AuthenticationSchemes);

		protected AuthenticationBase(AuthenticationSchemes scheme, NameValueCollection parameters)
		{
		}

		internal static string CreateNonceValue()
		{
			return null;
		}

		internal static NameValueCollection ParseParameters(string value)
		{
			return null;
		}

		internal abstract string ToBasicString();

		internal abstract string ToDigestString();

		public override string ToString()
		{
			return null;
		}
	}
}
