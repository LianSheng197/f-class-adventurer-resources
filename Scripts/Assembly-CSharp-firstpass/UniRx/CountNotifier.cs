using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public class CountNotifier : IObservable<CountChangedStatus>
	{
		private readonly object lockObject;

		private readonly Subject<CountChangedStatus> statusChanged;

		private readonly int max;

		public int Max => 0;

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CountNotifier(int max = int.MaxValue)
		{
		}

		public IDisposable Increment(int incrementCount = 1)
		{
			return null;
		}

		public void Decrement(int decrementCount = 1)
		{
		}

		public IDisposable Subscribe(IObserver<CountChangedStatus> observer)
		{
			return null;
		}
	}
}
