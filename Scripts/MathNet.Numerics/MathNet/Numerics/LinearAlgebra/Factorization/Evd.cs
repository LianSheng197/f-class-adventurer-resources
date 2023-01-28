using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class Evd<T> : ISolver<T> where T : struct, IEquatable<T>, IFormattable
	{
		public bool IsSymmetric
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public abstract T Determinant { get; }

		public abstract int Rank { get; }

		public abstract bool IsFullRank { get; }

		public Vector<System.Numerics.Complex> EigenValues
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> EigenVectors
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Matrix<T> D
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected Evd(Matrix<T> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<T> blockDiagonal, bool isSymmetric)
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
