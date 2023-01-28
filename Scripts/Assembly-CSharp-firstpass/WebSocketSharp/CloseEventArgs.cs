using System;

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private ushort _code;

		private PayloadData _payloadData;

		private string _reason;

		internal PayloadData PayloadData => null;

		public ushort Code => 0;

		public string Reason => null;

		public bool WasClean
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		internal CloseEventArgs()
		{
		}

		internal CloseEventArgs(ushort code)
		{
		}

		internal CloseEventArgs(CloseStatusCode code)
		{
		}

		internal CloseEventArgs(PayloadData payloadData)
		{
		}

		internal CloseEventArgs(ushort code, string reason)
		{
		}

		internal CloseEventArgs(CloseStatusCode code, string reason)
		{
		}
	}
}
