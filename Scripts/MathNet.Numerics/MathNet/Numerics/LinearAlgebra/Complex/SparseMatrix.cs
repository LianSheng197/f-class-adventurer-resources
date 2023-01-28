using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	[DebuggerDisplay("SparseMatrix {RowCount}x{ColumnCount}-Complex {NonZerosCount}-NonZero")]
	public class SparseMatrix : Matrix
	{
		private readonly SparseCompressedRowMatrixStorage<System.Numerics.Complex> _storage;

		public int NonZerosCount => 0;

		public SparseMatrix(SparseCompressedRowMatrixStorage<System.Numerics.Complex> storage)
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

		public static SparseMatrix OfMatrix(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		public static SparseMatrix OfArray(System.Numerics.Complex[,] array)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, System.Numerics.Complex>> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, System.Numerics.Complex)> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfRowMajor(int rows, int columns, IEnumerable<System.Numerics.Complex> rowMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumnMajor(int rows, int columns, IList<System.Numerics.Complex> columnMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumns(IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(params System.Numerics.Complex[][] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(IEnumerable<System.Numerics.Complex[]> columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(params Vector<System.Numerics.Complex>[] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(IEnumerable<Vector<System.Numerics.Complex>> columns)
		{
			return null;
		}

		public static SparseMatrix OfRows(IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static SparseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(params System.Numerics.Complex[][] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(IEnumerable<System.Numerics.Complex[]> rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(params Vector<System.Numerics.Complex>[] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(IEnumerable<Vector<System.Numerics.Complex>> rows)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(Vector<System.Numerics.Complex> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(int rows, int columns, Vector<System.Numerics.Complex> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(System.Numerics.Complex[] diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(int rows, int columns, System.Numerics.Complex[] diagonal)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, System.Numerics.Complex value)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, Func<int, int, System.Numerics.Complex> init)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, System.Numerics.Complex value)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, Func<int, System.Numerics.Complex> init)
		{
			return null;
		}

		public static SparseMatrix CreateIdentity(int order)
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

		private void LowerTriangleImpl(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		private void UpperTriangleImpl(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		private void StrictlyLowerTriangleImpl(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<System.Numerics.Complex> result)
		{
		}

		private void StrictlyUpperTriangleImpl(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoNegate(Matrix<System.Numerics.Complex> result)
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

		protected override void DoAdd(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		private void DoMultiplySparse(SparseMatrix other, SparseMatrix result)
		{
		}

		protected override void DoMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<System.Numerics.Complex> divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void KroneckerProduct(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
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

		public static SparseMatrix operator *(SparseMatrix leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(System.Numerics.Complex leftSide, SparseMatrix rightSide)
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

		public static SparseMatrix operator %(SparseMatrix leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public override string ToTypeString()
		{
			return null;
		}
	}
}
