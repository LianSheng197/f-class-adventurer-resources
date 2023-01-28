namespace UniRx
{
	public struct CancellationToken
	{
		private readonly ICancelable source;

		public static readonly CancellationToken Empty;

		public static readonly CancellationToken None;

		public bool IsCancellationRequested => false;

		public CancellationToken(ICancelable source)
		{
		}

		public void ThrowIfCancellationRequested()
		{
		}
	}
}
