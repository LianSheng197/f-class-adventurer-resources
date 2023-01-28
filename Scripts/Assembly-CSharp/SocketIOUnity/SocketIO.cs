using System.Collections.Generic;
using UnityEngine;
using socket.io;

namespace SocketIOUnity
{
	public class SocketIO : MonoBehaviour
	{
		public enum EventType
		{
			none = 0,
			msg = 1,
			SubscribeChannel = 2,
			SubscribeGuildChannel = 3,
			KickGuildUser = 4,
			size = 5
		}

		public delegate void RecvReceiver(string Response = "");

		protected Socket _socket;

		protected string _serverUrl;

		protected string _nameSpace;

		public RecvReceiver _ConnectReceiver;

		public RecvReceiver _ReConnectReceiver;

		public RecvReceiver _DisConnectReceiver;

		protected Dictionary<EventType, RecvReceiver> _ReceiverList;

		private static List<object> _socketList;

		public virtual void Initialize(string serverUrl, string nameSpace = "")
		{
		}

		protected virtual string GetUrl()
		{
			return null;
		}

		protected virtual void Connect()
		{
		}

		protected virtual void SendEnd(string EventType, string Reqeust, string Response)
		{
		}

		public virtual void SetRecvReceiver(EventType EventType, RecvReceiver del)
		{
		}

		public virtual void Send(EventType EventType, string data)
		{
		}

		public virtual void SendJson(EventType EventType, string data)
		{
		}
	}
}
