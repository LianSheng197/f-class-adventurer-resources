namespace UniRx
{
	public interface IAsyncMessagePublisher
	{
		IObservable<Unit> PublishAsync<T>(T message);
	}
}
