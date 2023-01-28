using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	[DebuggerDisplay("DenseMatrix {RowCount}x{ColumnCount}-Single")]
	public class DenseMatrix : Matrix
	{
		private readonly int _rowCount;

		private readonly int _columnCount;

		private readonly float[] _values;

		public float[] Values => null;

		public DenseMatrix(DenseColumnMajorMatrixStorage<float> storage)
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

		public DenseMatrix(int rows, int columns, float[] storage)
			: base(null)
		{
		}

		public static DenseMatrix OfMatrix(Matrix<float> matrix)
		{
			return null;
		}

		public static DenseMatrix OfArray(float[,] array)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, float>> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfIndexed(int rows, int columns, IEnumerable<(int, int, float)> enumerable)
		{
			return null;
		}

		public static DenseMatrix OfColumnMajor(int rows, int columns, IEnumerable<float> columnMajor)
		{
			return null;
		}

		public static DenseMatrix OfColumns(IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumns(int rows, int columns, IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(params float[][] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnArrays(IEnumerable<float[]> columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(params Vector<float>[] columns)
		{
			return null;
		}

		public static DenseMatrix OfColumnVectors(IEnumerable<Vector<float>> columns)
		{
			return null;
		}

		public static DenseMatrix OfRows(IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static DenseMatrix OfRows(int rows, int columns, IEnumerable<IEnumerable<float>> data)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(params float[][] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowArrays(IEnumerable<float[]> rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(params Vector<float>[] rows)
		{
			return null;
		}

		public static DenseMatrix OfRowVectors(IEnumerable<Vector<float>> rows)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(Vector<float> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalVector(int rows, int columns, Vector<float> diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(float[] diagonal)
		{
			return null;
		}

		public static DenseMatrix OfDiagonalArray(int rows, int columns, float[] diagonal)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, float value)
		{
			return null;
		}

		public static DenseMatrix Create(int rows, int columns, Func<int, int, float> init)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, float value)
		{
			return null;
		}

		public static DenseMatrix CreateDiagonal(int rows, int columns, Func<int, float> init)
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

		protected override void DoNegate(Matrix<float> result)
		{
		}

		protected override void DoAdd(float scalar, Matrix<float> result)
		{
		}

		protected override void DoAdd(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoSubtract(float scalar, Matrix<float> result)
		{
		}

		protected override void DoSubtract(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoMultiply(float scalar, Matrix<float> result)
		{
		}

		protected override void DoMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoDivide(float divisor, Matrix<float> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<float> divisor, Matrix<float> result)
		{
		}

		protected override void DoPointwisePower(Matrix<float> exponent, Matrix<float> result)
		{
		}

		protected override void DoModulus(float divisor, Matrix<float> result)
		{
		}

		protected override void DoModulusByThis(float dividend, Matrix<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Matrix<float> result)
		{
		}

		protected override void DoRemainderByThis(float dividend, Matrix<float> result)
		{
		}

		public override float Trace()
		{
			return 0f;
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

		public static DenseMatrix operator *(DenseMatrix leftSide, float rightSide)
		{
			return null;
		}

		public static DenseMatrix operator *(float leftSide, DenseMatrix rightSide)
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

		public static DenseMatrix operator %(DenseMatrix leftSide, float rightSide)
		{
			return null;
		}

		public override bool IsSymmetric()
		{
			return false;
		}

		public override Cholesky<float> Cholesky()
		{
			return null;
		}

		public override LU<float> LU()
		{
			return null;
		}

		public override QR<float> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<float> GramSchmidt()
		{
			return null;
		}

		public override Svd<float> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<float> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
