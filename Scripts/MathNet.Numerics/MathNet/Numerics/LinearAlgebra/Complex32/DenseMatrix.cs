using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	[DebuggerDisplay("DenseMatrix {RowCount}x{ColumnCount}-Complex32")]
	public class DenseMatrix : Matrix
	{
		private readonly int _rowCount;

		private readonly int _columnCount;

		private readonly MathNet.Numerics.Complex32[] _values;

		public MathNet.Numerics.Complex32[] Values => null;

		public DenseMatrix(DenseColumnMajorMatrixStorage<MathNet.Numerics.Complex32> storage)
			: base(null)
		{
		}

		public DenseMatrix(int order)
			: base(null)
		{
		}

		public DenseMatrix(int rows, int columns)
			: base(null)
		{
		}

		public DenseMatrix(int rows, int columns, MathNet.Numerics.Complex32[] storage)
			: base(null)
		{
		}

		public static DenseMatrix OfMatrix(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		public static DenseMatrix OfArray(MathNet.Numerics.Complex32[,] array)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, MathNet.Numerics.Complex32>> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, MathNet.Numerics.Complex32)> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfColumnMajor(int rows, int columns, IEnumerable<MathNet.Numerics.Complex32> columnMajor)
		{
			return null;
		}

		public static DenseMatrix OfColumns(IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(params MathNet.Numerics.Complex32[][] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(IEnumerable<MathNet.Numerics.Complex32[]> columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(params Vector<MathNet.Numerics.Complex32>[] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(IEnumerable<Vector<MathNet.Numerics.Complex32>> columns)
		{
			return null;
		}

		public static DenseMatrix OfRows(IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static DenseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<MathNet.Numerics.Complex32>> data)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(params MathNet.Numerics.Complex32[][] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(IEnumerable<MathNet.Numerics.Complex32[]> rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(params Vector<MathNet.Numerics.Complex32>[] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(IEnumerable<Vector<MathNet.Numerics.Complex32>> rows)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(Vector<MathNet.Numerics.Complex32> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(int rows, int columns, Vector<MathNet.Numerics.Complex32> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(MathNet.Numerics.Complex32[] diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(int rows, int columns, MathNet.Numerics.Complex32[] diagonal)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, Func<int, int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, Func<int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		public static DenseMatrix CreateIdentity(int order)
		{
			return null;
		}

		public static DenseMatrix CreateRandom(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		public override double L1Norm()
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

		protected override void DoNegate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
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

		protected override void DoTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivide(MathNet.Numerics.Complex32 divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<MathNet.Numerics.Complex32> divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(Matrix<MathNet.Numerics.Complex32> exponent, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override MathNet.Numerics.Complex32 Trace()
		{
			return default(MathNet.Numerics.Complex32);
		}

		public static DenseMatrix operator +(DenseMatrix leftSide, DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator +(DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator -(DenseMatrix leftSide, DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator -(DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(DenseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(MathNet.Numerics.Complex32 leftSide, DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(DenseMatrix leftSide, DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseVector operator *(DenseMatrix leftSide, DenseVector rightSide)
		{
			return null;
		}

		public static DenseVector operator *(DenseVector leftSide, DenseMatrix rightSide)
		{
			return null;
		}

		public static DenseMatrix operator %(DenseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public override bool IsSymmetric()
		{
			return false;
		}

		public override bool IsHermitian()
		{
			return false;
		}

		public override Cholesky<MathNet.Numerics.Complex32> Cholesky()
		{
			return null;
		}

		public override LU<MathNet.Numerics.Complex32> LU()
		{
			return null;
		}

		public override QR<MathNet.Numerics.Complex32> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<MathNet.Numerics.Complex32> GramSchmidt()
		{
			return null;
		}

		public override Svd<MathNet.Numerics.Complex32> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<MathNet.Numerics.Complex32> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
