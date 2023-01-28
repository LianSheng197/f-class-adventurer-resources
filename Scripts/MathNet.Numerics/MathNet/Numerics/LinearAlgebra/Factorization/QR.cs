using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class QR<T> : ISolver<T> where T : struct, IEquatable<T>, IFormattable
	{
		private readonly Lazy<Matrix<T>> _lazyR;

		protected readonly Matrix<T> FullR;

		protected readonly QRMethod Method;

		public Matrix<T> Q
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> R => null;

		public abstract T Determinant { get; }

		public abstract bool IsFullRank { get; }

		protected QR(Matrix<T> q, Matrix<T> rFull, QRMethod method)
		{
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
