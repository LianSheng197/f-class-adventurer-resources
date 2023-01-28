using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	[DebuggerDisplay("SparseMatrix {RowCount}x{ColumnCount}-Single {NonZerosCount}-NonZero")]
	public class SparseMatrix : Matrix
	{
		private readonly SparseCompressedRowMatrixStorage<float> _storage;

		public int NonZerosCount => 0;

		public SparseMatrix(SparseCompressedRowMatrixStorage<float> storage)
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

		public static SparseMatrix OfMatrix(Matrix<float> matrix)
		{
			return null;
		}

		public static SparseMatrix OfArray(float[,] array)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, float>> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, float)> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfRowMajor(int rows, int columns, IEnumerable<float> rowMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumnMajor(int rows, int columns, IList<float> columnMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumns(IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(params float[][] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(IEnumerable<float[]> columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(params Vector<float>[] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(IEnumerable<Vector<float>> columns)
		{
			return null;
		}

		public static SparseMatrix OfRows(IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static SparseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(params float[][] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(IEnumerable<float[]> rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(params Vector<float>[] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(IEnumerable<Vector<float>> rows)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(Vector<float> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(int rows, int columns, Vector<float> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(float[] diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(int rows, int columns, float[] diagonal)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, float value)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, Func<int, int, float> init)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, float value)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, Func<int, float> init)
		{
			return null;
		}

		public static SparseMatrix CreateIdentity(int order)
		{
			return null;
		}

		public override Matrix<float> LowerTriangle()
		{
			return null;
		}

		public override void LowerTriangle(Matrix<float> result)
		{
		}

		private void LowerTriangleImpl(Matrix<float> result)
		{
		}

		public override Matrix<float> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<float> result)
		{
		}

		private void UpperTriangleImpl(Matrix<float> result)
		{
		}

		public override Matrix<float> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<float> result)
		{
		}

		private void StrictlyLowerTriangleImpl(Matrix<float> result)
		{
		}

		public override Matrix<float> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<float> result)
		{
		}

		private void StrictlyUpperTriangleImpl(Matrix<float> result)
		{
		}

		protected override void DoNegate(Matrix<float> result)
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

		protected override void DoAdd(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoSubtract(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoMultiply(float scalar, Matrix<float> result)
		{
		}

		protected override void DoMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		private void DoMultiplySparse(SparseMatrix other, SparseMatrix result)
		{
		}

		protected override void DoMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<float> divisor, Matrix<float> result)
		{
		}

		public override void KroneckerProduct(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoModulus(float divisor, Matrix<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Matrix<float> result)
		{
		}

		public override bool IsSymmetric()
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

		public static SparseMatrix operator *(SparseMatrix leftSide, float rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(float leftSide, SparseMatrix rightSide)
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

		public static SparseMatrix operator %(SparseMatrix leftSide, float rightSide)
		{
			return null;
		}

		public override string ToTypeString()
		{
			return null;
		}
	}
}
