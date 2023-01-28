using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	public abstract class VectorBuilder<T> where T : struct, IEquatable<T>, IFormattable
	{
		public abstract T Zero { get; }

		public abstract T One { get; }

		public Vector<T> OfStorage(VectorStorage<T> storage)
		{
			return null;
		}

		public Vector<T> SameAs<TU>(Vector<TU> example, int length) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<T> SameAs<TU>(Vector<TU> example) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<T> SameAs<TU>(Matrix<TU> example, int length) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<T> SameAs(Vector<T> example, Vector<T> otherExample, int length)
		{
			return null;
		}

		public Vector<T> SameAs(Vector<T> example, Vector<T> otherExample)
		{
			return null;
		}

		public Vector<T> SameAs(Matrix<T> matrix, Vector<T> vector, int length)
		{
			return null;
		}

		public abstract Vector<T> Random(int length, IContinuousDistribution distribution);

		public Vector<T> Random(int length)
		{
			return null;
		}

		public Vector<T> Random(int length, int seed)
		{
			return null;
		}

		public abstract Vector<T> Dense(DenseVectorStorage<T> storage);

		public Vector<T> Dense(int size)
		{
			return null;
		}

		public Vector<T> Dense(T[] array)
		{
			return null;
		}

		public Vector<T> Dense(int length, T value)
		{
			return null;
		}

		public Vector<T> Dense(int length, Func<int, T> init)
		{
			return null;
		}

		public Vector<T> DenseOfVector(Vector<T> vector)
		{
			return null;
		}

		public Vector<T> DenseOfArray(T[] array)
		{
			return null;
		}

		public Vector<T> DenseOfEnumerable(IEnumerable<T> enumerable)
		{
			return null;
		}

		public Vector<T> DenseOfIndexed(int length, IEnumerable<Tuple<int, T>> enumerable)
		{
			return null;
		}

		public Vector<T> DenseOfIndexed(int length, IEnumerable<(int, T)> enumerable)
		{
			return null;
		}

		public abstract Vector<T> Sparse(SparseVectorStorage<T> storage);

		public Vector<T> Sparse(int size)
		{
			return null;
		}

		public Vector<T> Sparse(int length, T value)
		{
			return null;
		}

		public Vector<T> Sparse(int length, Func<int, T> init)
		{
			return null;
		}

		public Vector<T> SparseOfVector(Vector<T> vector)
		{
			return null;
		}

		public Vector<T> SparseOfArray(T[] array)
		{
			return null;
		}

		public Vector<T> SparseOfEnumerable(IEnumerable<T> enumerable)
		{
			return null;
		}

		public Vector<T> SparseOfIndexed(int length, IEnumerable<Tuple<int, T>> enumerable)
		{
			return null;
		}

		public Vector<T> SparseOfIndexed(int length, IEnumerable<(int, T)> enumerable)
		{
			return null;
		}
	}
}
