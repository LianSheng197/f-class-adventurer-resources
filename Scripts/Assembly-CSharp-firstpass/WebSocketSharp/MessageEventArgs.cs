using System;

namespace WebSocketSharp
{
	public class MessageEventArgs : EventArgs
	{
		private string _data;

		private bool _dataSet;

		private Opcode _opcode;

		private byte[] _rawData;

		public string Data => null;

		public bool IsBinary => false;

		public bool IsPing => false;

		public bool IsText => false;

		public byte[] RawData => null;

		[Obsolete("This property will be removed. Use any of the Is properties instead.")]
		public Opcode Type => default(Opcode);

		internal MessageEventArgs(WebSocketFrame frame)
		{
		}

		internal MessageEventArgs(Opcode opcode, byte[] rawData)
		{
		}
	}
}
