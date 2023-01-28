using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	public static class CreateVector
	{
		public static Vector<T> WithStorage<T>(VectorStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T, TU>(Vector<TU> example, int length) where T : struct, IEquatable<T>, IFormattable where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T, TU>(Vector<TU> example) where T : struct, IEquatable<T>, IFormattable where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T, TU>(Matrix<TU> example, int length) where T : struct, IEquatable<T>, IFormattable where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T>(Vector<T> example, Vector<T> otherExample, int length) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T>(Vector<T> example, Vector<T> otherExample) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SameAs<T>(Matrix<T> matrix, Vector<T> vector, int length) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Random<T>(int length, IContinuousDistribution distribution) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Random<T>(int length) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Random<T>(int length, int seed) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Dense<T>(DenseVectorStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Dense<T>(int size) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Dense<T>(T[] array) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Dense<T>(int length, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Dense<T>(int length, Func<int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> DenseOfVector<T>(Vector<T> vector) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> DenseOfArray<T>(T[] array) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> DenseOfEnumerable<T>(IEnumerable<T> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> DenseOfIndexed<T>(int length, IEnumerable<Tuple<int, T>> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> DenseOfIndexed<T>(int length, IEnumerable<(int, T)> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Sparse<T>(SparseVectorStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Sparse<T>(int size) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Sparse<T>(int length, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Sparse<T>(int length, Func<int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SparseOfVector<T>(Vector<T> vector) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SparseOfArray<T>(T[] array) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SparseOfEnumerable<T>(IEnumerable<T> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SparseOfIndexed<T>(int length, IEnumerable<Tuple<int, T>> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> SparseOfIndexed<T>(int length, IEnumerable<(int, T)> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}
	}
}
