using System.Collections.Generic;

namespace UniRx
{
	public static class ReactivePropertyExtensions
	{
		public static ReactiveProperty<T> ToReactiveProperty<T>(this IObservable<T> source)
		{
			return null;
		}

		public static ReactiveProperty<T> ToReactiveProperty<T>(this IObservable<T> source, T initialValue)
		{
			return null;
		}

		public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(this IObservable<T> source)
		{
			return null;
		}

		public static ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(this IObservable<T> source)
		{
			return null;
		}

		public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(this IObservable<T> source, T initialValue)
		{
			return null;
		}

		public static ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(this IObservable<T> source, T initialValue)
		{
			return null;
		}

		public static IObservable<T> SkipLatestValueOnSubscribe<T>(this IReadOnlyReactiveProperty<T> source)
		{
			return null;
		}

		public static IObservable<bool> CombineLatestValuesAreAllTrue(this IEnumerable<IObservable<bool>> sources)
		{
			return null;
		}

		public static IObservable<bool> CombineLatestValuesAreAllFalse(this IEnumerable<IObservable<bool>> sources)
		{
			return null;
		}
	}
}
