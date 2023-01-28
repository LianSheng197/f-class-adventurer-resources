using System;

namespace Gaa
{
	[Serializable]
	public class IapResult
	{
		public int code;

		public string message;

		public bool IsSuccess()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
