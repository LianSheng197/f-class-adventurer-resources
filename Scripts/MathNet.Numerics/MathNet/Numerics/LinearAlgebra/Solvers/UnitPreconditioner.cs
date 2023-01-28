using System;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class UnitPreconditioner<T> : IPreconditioner<T> where T : struct, IEquatable<T>, IFormattable
	{
		private int _size;

		public void Initialize(Matrix<T> matrix)
		{
		}

		public void Approximate(Vector<T> rhs, Vector<T> lhs)
		{
		}
	}
}
