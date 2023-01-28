using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	[DebuggerDisplay("DenseMatrix {RowCount}x{ColumnCount}-Double")]
	public class DenseMatrix : Matrix
	{
		private readonly int _rowCount;

		private readonly int _columnCount;

		private readonly double[] _values;

		public double[] Values => null;

		public DenseMatrix(DenseColumnMajorMatrixStorage<double> storage)
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

		public DenseMatrix(int rows, int columns, double[] storage)
			: base(null)
		{
		}

		public static DenseMatrix OfMatrix(Matrix<double> matrix)
		{
			return null;
		}

		public static DenseMatrix OfArray(double[,] array)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, double>> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, double)> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfColumnMajor(int rows, int columns, IEnumerable<double> columnMajor)
		{
			return null;
		}

		public static DenseMatrix OfColumns(IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(params double[][] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(IEnumerable<double[]> columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(params Vector<double>[] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(IEnumerable<Vector<double>> columns)
		{
			return null;
		}

		public static DenseMatrix OfRows(IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static DenseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<double>> data)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(params double[][] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(IEnumerable<double[]> rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(params Vector<double>[] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(IEnumerable<Vector<double>> rows)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(Vector<double> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(int rows, int columns, Vector<double> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(double[] diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(int rows, int columns, double[] diagonal)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, double value)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, Func<int, int, double> init)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, double value)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, Func<int, double> init)
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

		protected override void DoNegate(Matrix<double> result)
		{
		}

		protected override void DoAdd(double scalar, Matrix<double> result)
		{
		}

		protected override void DoAdd(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoSubtract(double scalar, Matrix<double> result)
		{
		}

		protected override void DoSubtract(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoMultiply(double scalar, Matrix<double> result)
		{
		}

		protected override void DoMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoDivide(double divisor, Matrix<double> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<double> divisor, Matrix<double> result)
		{
		}

		protected override void DoPointwisePower(Matrix<double> exponent, Matrix<double> result)
		{
		}

		protected override void DoModulus(double divisor, Matrix<double> result)
		{
		}

		protected override void DoModulusByThis(double dividend, Matrix<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Matrix<double> result)
		{
		}

		protected override void DoRemainderByThis(double dividend, Matrix<double> result)
		{
		}

		public override double Trace()
		{
			return 0.0;
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

		public static DenseMatrix operator *(DenseMatrix leftSide, double rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(double leftSide, DenseMatrix rightSide)
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

		public static DenseMatrix operator %(DenseMatrix leftSide, double rightSide)
		{
			return null;
		}

		public override bool IsSymmetric()
		{
			return false;
		}

		public override Cholesky<double> Cholesky()
		{
			return null;
		}

		public override LU<double> LU()
		{
			return null;
		}

		public override QR<double> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<double> GramSchmidt()
		{
			return null;
		}

		public override Svd<double> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<double> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
