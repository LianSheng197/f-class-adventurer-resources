namespace UniRx
{
	public interface IOptimizedObservable<T> : IObservable<T>
	{
		bool IsRequiredSubscribeOnCurrentThread();
	}
}
