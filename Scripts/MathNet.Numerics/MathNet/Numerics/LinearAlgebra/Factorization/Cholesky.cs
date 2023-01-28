using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class Cholesky<T> : ISolver<T> where T : struct, IEquatable<T>, IFormattable
	{
		public Matrix<T> Factor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public abstract T Determinant { get; }

		public abstract T DeterminantLn { get; }

		protected Cholesky(Matrix<T> factor)
		{
		}

		public abstract void Factorize(Matrix<T> matrix);

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
	}
}
