using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	[DebuggerDisplay("SparseMatrix {RowCount}x{ColumnCount}-Double {NonZerosCount}-NonZero")]
	public class SparseMatrix : Matrix
	{
		private readonly SparseCompressedRowMatrixStorage<double> _storage;

		public int NonZerosCount => 0;

		public SparseMatrix(SparseCompressedRowMatrixStorage<double> storage)
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

		public static SparseMatrix OfMatrix(Matrix<double> matrix)
		{
			return null;
		}

		public static SparseMatrix OfArray(double[,] array)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, double>> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, double)> enumerable)
		{
			return null;
		}

		public static SparseMatrix OfRowMajor(int rows, int columns, IEnumerable<double> rowMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumnMajor(int rows, int columns, IList<double> columnMajor)
		{
			return null;
		}

		public static SparseMatrix OfColumns(IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(params double[][] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnArrays(IEnumerable<double[]> columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(params Vector<double>[] columns)
		{
			return null;
		}

		public static SparseMatrix OfColumnVectors(IEnumerable<Vector<double>> columns)
		{
			return null;
		}

		public static SparseMatrix OfRows(IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static SparseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(params double[][] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowArrays(IEnumerable<double[]> rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(params Vector<double>[] rows)
		{
			return null;
		}

		public static SparseMatrix OfRowVectors(IEnumerable<Vector<double>> rows)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(Vector<double> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalVector(int rows, int columns, Vector<double> diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(double[] diagonal)
		{
			return null;
		}

		public static SparseMatrix OfDiagonalArray(int rows, int columns, double[] diagonal)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, double value)
		{
			return null;
		}

		public static SparseMatrix Create(int rows, int columns, Func<int, int, double> init)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, double value)
		{
			return null;
		}

		public static SparseMatrix CreateDiagonal(int rows, int columns, Func<int, double> init)
		{
			return null;
		}

		public static SparseMatrix CreateIdentity(int order)
		{
			return null;
		}

		public override Matrix<double> LowerTriangle()
		{
			return null;
		}

		public override void LowerTriangle(Matrix<double> result)
		{
		}

		private void LowerTriangleImpl(Matrix<double> result)
		{
		}

		public override Matrix<double> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<double> result)
		{
		}

		private void UpperTriangleImpl(Matrix<double> result)
		{
		}

		public override Matrix<double> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<double> result)
		{
		}

		private void StrictlyLowerTriangleImpl(Matrix<double> result)
		{
		}

		public override Matrix<double> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<double> result)
		{
		}

		private void StrictlyUpperTriangleImpl(Matrix<double> result)
		{
		}

		protected override void DoNegate(Matrix<double> result)
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

		protected override void DoAdd(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoSubtract(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoMultiply(double scalar, Matrix<double> result)
		{
		}

		protected override void DoMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		private void DoMultiplySparse(SparseMatrix other, SparseMatrix result)
		{
		}

		protected override void DoMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<double> divisor, Matrix<double> result)
		{
		}

		public override void KroneckerProduct(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoModulus(double divisor, Matrix<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Matrix<double> result)
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

		public static SparseMatrix operator *(SparseMatrix leftSide, double rightSide)
		{
			return null;
		}

		public static SparseMatrix operator *(double leftSide, SparseMatrix rightSide)
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

		public static SparseMatrix operator %(SparseMatrix leftSide, double rightSide)
		{
			return null;
		}

		public override string ToTypeString()
		{
			return null;
		}
	}
}
