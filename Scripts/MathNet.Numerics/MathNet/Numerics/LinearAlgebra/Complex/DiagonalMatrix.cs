using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	[DebuggerDisplay("DiagonalMatrix {RowCount}x{ColumnCount}-Complex")]
	public class DiagonalMatrix : Matrix
	{
		private readonly System.Numerics.Complex[] _data;

		public DiagonalMatrix(DiagonalMatrixStorage<System.Numerics.Complex> storage)
			: base(null)
		{
		}

		public DiagonalMatrix(int order)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns, System.Numerics.Complex diagonalValue)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns, System.Numerics.Complex[] diagonalStorage)
			: base(null)
		{
		}

		public static DiagonalMatrix OfMatrix(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		public static DiagonalMatrix OfArray(System.Numerics.Complex[,] array)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<Tuple<int, System.Numerics.Complex>> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<(int, System.Numerics.Complex)> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfDiagonal(int rows, int columns, IEnumerable<System.Numerics.Complex> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix Create(int rows, int columns, Func<int, System.Numerics.Complex> init)
		{
			return null;
		}

		public static DiagonalMatrix CreateIdentity(int order)
		{
			return null;
		}

		public static DiagonalMatrix CreateRandom(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		protected override void DoNegate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivide(System.Numerics.Complex divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivideByThis(System.Numerics.Complex dividend, Matrix<System.Numerics.Complex> result)
		{
		}

		public override System.Numerics.Complex Determinant()
		{
			return default(System.Numerics.Complex);
		}

		public override Vector<System.Numerics.Complex> Diagonal()
		{
			return null;
		}

		public override void SetDiagonal(System.Numerics.Complex[] source)
		{
		}

		public override void SetDiagonal(Vector<System.Numerics.Complex> source)
		{
		}

		public override double L1Norm()
		{
			return 0.0;
		}

		public override double L2Norm()
		{
			return 0.0;
		}

		public override double InfinityNorm()
		{
			return 0.0;
		}

		public override double FrobeniusNorm()
		{
			return 0.0;
		}

		public override System.Numerics.Complex ConditionNumber()
		{
			return default(System.Numerics.Complex);
		}

		public override Matrix<System.Numerics.Complex> Inverse()
		{
			return null;
		}

		public override Matrix<System.Numerics.Complex> LowerTriangle()
		{
			return null;
		}

		public override void LowerTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> SubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
			return null;
		}

		public override void PermuteColumns(Permutation p)
		{
		}

		public override void PermuteRows(Permutation p)
		{
		}

		public sealed override bool IsSymmetric()
		{
			return false;
		}

		public sealed override bool IsHermitian()
		{
			return false;
		}
	}
}
