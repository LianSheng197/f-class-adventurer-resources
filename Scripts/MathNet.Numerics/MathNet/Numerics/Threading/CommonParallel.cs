using System;
using System.Threading.Tasks;

namespace MathNet.Numerics.Threading
{
	internal static class CommonParallel
	{
		private static ParallelOptions CreateParallelOptions()
		{
			return null;
		}

		public static void For(int fromInclusive, int toExclusive, Action<int, int> body)
		{
		}

		public static void For(int fromInclusive, int toExclusive, int rangeSize, Action<int, int> body)
		{
		}

		public static void Invoke(params Action[] actions)
		{
		}

		public static T Aggregate<T>(int fromInclusive, int toExclusive, Func<int, T> select, Func<T[], T> reduce)
		{
			return default(T);
		}

		public static TOut Aggregate<T, TOut>(T[] array, Func<int, T, TOut> select, Func<TOut[], TOut> reduce)
		{
			return default(TOut);
		}

		public static T Aggregate<T>(int fromInclusive, int toExclusive, Func<int, T> select, Func<T, T, T> reducePair, T reduceDefault)
		{
			return default(T);
		}

		public static TOut Aggregate<T, TOut>(T[] array, Func<int, T, TOut> select, Func<TOut, TOut, TOut> reducePair, TOut reduceDefault)
		{
			return default(TOut);
		}
	}
}
