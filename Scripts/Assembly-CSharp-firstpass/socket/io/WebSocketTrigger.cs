using System;
using System.Runtime.CompilerServices;
using UniRx;
using UniRx.Triggers;

namespace socket.io
{
	public class WebSocketTrigger : ObservableTriggerBase
	{
		private IDisposable _cancelPingPong;

		private Subject<string> _onRecv;

		public WebSocketWrapper WebSocket
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

		public string LastWebSocketError
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

		public bool IsConnected => false;

		public bool IsProbed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsUpgraded
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IObservable<string> OnRecvAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}

		private void Update()
		{
		}

		private void ReceiveWebSocketData()
		{
		}

		public void CheckAndHandleWebSocketDisconnect()
		{
		}
	}
}
