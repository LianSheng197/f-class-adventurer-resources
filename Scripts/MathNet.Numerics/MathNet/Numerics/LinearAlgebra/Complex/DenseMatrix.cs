using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	[DebuggerDisplay("DenseMatrix {RowCount}x{ColumnCount}-Complex")]
	public class DenseMatrix : Matrix
	{
		private readonly int _rowCount;

		private readonly int _columnCount;

		private readonly System.Numerics.Complex[] _values;

		public System.Numerics.Complex[] Values => null;

		public DenseMatrix(DenseColumnMajorMatrixStorage<System.Numerics.Complex> storage)
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

		public DenseMatrix(int rows, int columns, System.Numerics.Complex[] storage)
			: base(null)
		{
		}

		public static DenseMatrix OfMatrix(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		public static DenseMatrix OfArray(System.Numerics.Complex[,] array)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, System.Numerics.Complex>> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, System.Numerics.Complex)> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfColumnMajor(int rows, int columns, IEnumerable<System.Numerics.Complex> columnMajor)
		{
			return null;
		}

		public static DenseMatrix OfColumns(IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(params System.Numerics.Complex[][] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(IEnumerable<System.Numerics.Complex[]> columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(params Vector<System.Numerics.Complex>[] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(IEnumerable<Vector<System.Numerics.Complex>> columns)
		{
			return null;
		}

		public static DenseMatrix OfRows(IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static DenseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<System.Numerics.Complex>> data)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(params System.Numerics.Complex[][] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(IEnumerable<System.Numerics.Complex[]> rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(params Vector<System.Numerics.Complex>[] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(IEnumerable<Vector<System.Numerics.Complex>> rows)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(Vector<System.Numerics.Complex> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(int rows, int columns, Vector<System.Numerics.Complex> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(System.Numerics.Complex[] diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(int rows, int columns, System.Numerics.Complex[] diagonal)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, System.Numerics.Complex value)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, Func<int, int, System.Numerics.Complex> init)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, System.Numerics.Complex value)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, Func<int, System.Numerics.Complex> init)
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

		protected override void DoNegate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
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

		protected override void DoTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivide(System.Numerics.Complex divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<System.Numerics.Complex> divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(Matrix<System.Numerics.Complex> exponent, Matrix<System.Numerics.Complex> result)
		{
		}

		public override System.Numerics.Complex Trace()
		{
			return default(System.Numerics.Complex);
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

		public static DenseMatrix operator *(DenseMatrix leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(System.Numerics.Complex leftSide, DenseMatrix rightSide)
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

		public static DenseMatrix operator %(DenseMatrix leftSide, System.Numerics.Complex rightSide)
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

		public override Cholesky<System.Numerics.Complex> Cholesky()
		{
			return null;
		}

		public override LU<System.Numerics.Complex> LU()
		{
			return null;
		}

		public override QR<System.Numerics.Complex> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<System.Numerics.Complex> GramSchmidt()
		{
			return null;
		}

		public override Svd<System.Numerics.Complex> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<System.Numerics.Complex> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
