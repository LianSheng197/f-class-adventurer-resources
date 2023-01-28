namespace WebSocketSharp.Net
{
	internal class HttpHeaderInfo
	{
		private string _name;

		private HttpHeaderType _type;

		internal bool IsMultiValueInRequest => false;

		internal bool IsMultiValueInResponse => false;

		public bool IsRequest => false;

		public bool IsResponse => false;

		public string Name => null;

		public HttpHeaderType Type => default(HttpHeaderType);

		internal HttpHeaderInfo(string name, HttpHeaderType type)
		{
		}

		public bool IsMultiValue(bool response)
		{
			return false;
		}

		public bool IsRestricted(bool response)
		{
			return false;
		}
	}
}
