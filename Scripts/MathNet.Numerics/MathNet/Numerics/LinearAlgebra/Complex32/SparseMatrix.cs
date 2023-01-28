using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	[DebuggerDisplay("SparseMatrix {RowCount}x{ColumnCount}-Complex32 {NonZerosCount}-NonZero")]
	public class SparseMatrix : Matrix
	{
		private readonly SparseCompressedRowMatrixStorage<MathNet.Numerics.Complex32> _storage;

		public int NonZerosCount => 0;

		public SparseMatrix(SparseCompressedRowMatrixStorage<MathNet.Numerics.Complex32> storage)
			: base(null)
		{
		}

		public SparseMatrix(int order)
			: base(null)
		{
		}

		public SparseMatrix(int rows, int columns)
			: base(null)
		{
		}

		public static SparseMatrix OfMatrix(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		public static SparseMatrix OfArray(MathNet.Numerics.Complex32[,] array)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, MathNet.Numerics.Complex32>> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, MathNet.Numerics.Complex32)> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfRowMajor(int rows, int columns, IEnumerable<MathNet.Numerics.Complex32> rowMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumnMajor(int rows, int columns, IList<MathNet.Numerics.Complex32> columnMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumns(IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(params MathNet.Numerics.Complex32[][] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(IEnumerable<MathNet.Numerics.Complex32[]> columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(params Vector<MathNet.Numerics.Complex32>[] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(IEnumerable<Vector<MathNet.Numerics.Complex32>> columns)
		{
			return null;
		}

		public static SparseMatrix OfRows(IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static SparseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(params MathNet.Numerics.Complex32[][] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(IEnumerable<MathNet.Numerics.Complex32[]> rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(params Vector<MathNet.Numerics.Complex32>[] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(IEnumerable<Vector<MathNet.Numerics.Complex32>> rows)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(Vector<MathNet.Numerics.Complex32> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(int rows, int columns, Vector<MathNet.Numerics.Complex32> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(MathNet.Numerics.Complex32[] diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(int rows, int columns, MathNet.Numerics.Complex32[] diagonal)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, Func<int, int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, Func<int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		public static SparseMatrix CreateIdentity(int order)
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

		private void LowerTriangleImpl(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		private void UpperTriangleImpl(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		private void StrictlyLowerTriangleImpl(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		private void StrictlyUpperTriangleImpl(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoNegate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override double InfinityNorm()
		{
			return 0.0;
		}

		public override double FrobeniusNorm()
		{
			return 0.0;
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

		protected override void DoMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		private void DoMultiplySparse(SparseMatrix other, SparseMatrix result)
		{
		}

		protected override void DoMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<MathNet.Numerics.Complex32> divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void KroneckerProduct(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override bool IsSymmetric()
		{
			return false;
		}

		public override bool IsHermitian()
		{
			return false;
		}

		public static SparseMatrix operator +(SparseMatrix leftSide, SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator +(SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator -(SparseMatrix leftSide, SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator -(SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(SparseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(MathNet.Numerics.Complex32 leftSide, SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(SparseMatrix leftSide, SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseVector operator *(SparseMatrix leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static SparseVector operator *(SparseVector leftSide, SparseMatrix rightSide)
		{
			return null;
		}

		public static SparseMatrix operator %(SparseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public override string ToTypeString()
		{
			return null;
		}
	}
}
