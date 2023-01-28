using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class Svd<T> : ISolver<T> where T : struct, IEquatable<T>, IFormattable
	{
		private readonly Lazy<Matrix<T>> _lazyW;

		protected readonly bool VectorsComputed;

		public Vector<T> S
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> U
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> VT
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> W => null;

		public abstract int Rank { get; }

		public abstract double L2Norm { get; }

		public abstract T ConditionNumber { get; }

		public abstract T Determinant { get; }

		protected Svd(Vector<T> s, Matrix<T> u, Matrix<T> vt, bool vectorsComputed)
		{
		}

		private Matrix<T> ComputeW()
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
	}
}
