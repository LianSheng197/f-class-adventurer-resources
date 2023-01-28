using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public sealed class BooleanDisposable : IDisposable, ICancelable
	{
		public bool IsDisposed
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

		public BooleanDisposable()
		{
		}

		internal BooleanDisposable(bool isDisposed)
		{
		}

		public void Dispose()
		{
		}
	}
}
