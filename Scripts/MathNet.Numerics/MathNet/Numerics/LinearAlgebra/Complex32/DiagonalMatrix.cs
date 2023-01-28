using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	[DebuggerDisplay("DiagonalMatrix {RowCount}x{ColumnCount}-Complex32")]
	public class DiagonalMatrix : Matrix
	{
		private readonly MathNet.Numerics.Complex32[] _data;

		public DiagonalMatrix(DiagonalMatrixStorage<MathNet.Numerics.Complex32> storage)
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

		public DiagonalMatrix(int rows, int columns, MathNet.Numerics.Complex32 diagonalValue)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns, MathNet.Numerics.Complex32[] diagonalStorage)
			: base(null)
		{
		}

		public static DiagonalMatrix OfMatrix(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		public static DiagonalMatrix OfArray(MathNet.Numerics.Complex32[,] array)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<Tuple<int, MathNet.Numerics.Complex32>> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<(int, MathNet.Numerics.Complex32)> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfDiagonal(int rows, int columns, IEnumerable<MathNet.Numerics.Complex32> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix Create(int rows, int columns, Func<int, MathNet.Numerics.Complex32> init)
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

		protected override void DoNegate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivide(MathNet.Numerics.Complex32 divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivideByThis(MathNet.Numerics.Complex32 dividend, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override MathNet.Numerics.Complex32 Determinant()
		{
			return default(MathNet.Numerics.Complex32);
		}

		public override Vector<MathNet.Numerics.Complex32> Diagonal()
		{
			return null;
		}

		public override void SetDiagonal(MathNet.Numerics.Complex32[] source)
		{
		}

		public override void SetDiagonal(Vector<MathNet.Numerics.Complex32> source)
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

		public override MathNet.Numerics.Complex32 ConditionNumber()
		{
			return default(MathNet.Numerics.Complex32);
		}

		public override Matrix<MathNet.Numerics.Complex32> Inverse()
		{
			return null;
		}

		public override Matrix<MathNet.Numerics.Complex32> LowerTriangle()
		{
			return null;
		}

		public override void LowerTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> SubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
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
