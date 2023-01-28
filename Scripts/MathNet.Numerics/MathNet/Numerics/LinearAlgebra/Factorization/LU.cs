using System;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class LU<T> : ISolver<T> where T : struct, IEquatable<T>, IFormattable
	{
		private static readonly T One;

		private readonly Lazy<Matrix<T>> _lazyL;

		private readonly Lazy<Matrix<T>> _lazyU;

		private readonly Lazy<Permutation> _lazyP;

		protected readonly Matrix<T> Factors;

		protected readonly int[] Pivots;

		public Matrix<T> L => null;

		public Matrix<T> U => null;

		public Permutation P => null;

		public abstract T Determinant { get; }

		protected LU(Matrix<T> factors, int[] pivots)
		{
		}

		private Matrix<T> ComputeL()
		{
			return null;
		}

		public virtual Matrix<T> Solve(Matrix<T> input)
		{
			return null;
		}

		public abstract void Solve(Matrix<T> input, Matrix<T> result);

		public virtual Vector<T> Solve(Vector<T> input)
		{
			return null;
		}

		public abstract void Solve(Vector<T> input, Vector<T> result);

		public abstract Matrix<T> Inverse();
	}
}
