using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public class EventPattern<TEventArgs> : EventPattern<object, TEventArgs>
	{
		public EventPattern(object sender, TEventArgs e)
		{
			((EventPattern<, >)(object)this)._002Ector((TSender)default(TEventArgs), (TEventArgs)default(_00211));
		}
	}
	public class EventPattern<TSender, TEventArgs> : IEquatable<EventPattern<TSender, TEventArgs>>, IEventPattern<TSender, TEventArgs>
	{
		public TSender Sender
		{
			[CompilerGenerated]
			get
			{
				return default(TSender);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TEventArgs EventArgs
		{
			[CompilerGenerated]
			get
			{
				return default(TEventArgs);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EventPattern(TSender sender, TEventArgs e)
		{
		}

		public bool Equals(EventPattern<TSender, TEventArgs> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(EventPattern<TSender, TEventArgs> first, EventPattern<TSender, TEventArgs> second)
		{
			return false;
		}

		public static bool operator !=(EventPattern<TSender, TEventArgs> first, EventPattern<TSender, TEventArgs> second)
		{
			return false;
		}
	}
}
