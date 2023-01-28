using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	[DebuggerDisplay("DiagonalMatrix {RowCount}x{ColumnCount}-Double")]
	public class DiagonalMatrix : Matrix
	{
		private readonly double[] _data;

		public DiagonalMatrix(DiagonalMatrixStorage<double> storage)
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

		public DiagonalMatrix(int rows, int columns, double diagonalValue)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns, double[] diagonalStorage)
			: base(null)
		{
		}

		public static DiagonalMatrix OfMatrix(Matrix<double> matrix)
		{
			return null;
		}

		public static DiagonalMatrix OfArray(double[,] array)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<Tuple<int, double>> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<(int, double)> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfDiagonal(int rows, int columns, IEnumerable<double> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix Create(int rows, int columns, Func<int, double> init)
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

		protected override void DoNegate(Matrix<double> result)
		{
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

		protected override void DoMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoDivide(double divisor, Matrix<double> result)
		{
		}

		protected override void DoDivideByThis(double dividend, Matrix<double> result)
		{
		}

		public override double Determinant()
		{
			return 0.0;
		}

		public override Vector<double> Diagonal()
		{
			return null;
		}

		public override void SetDiagonal(double[] source)
		{
		}

		public override void SetDiagonal(Vector<double> source)
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

		public override double ConditionNumber()
		{
			return 0.0;
		}

		public override Matrix<double> Inverse()
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

		public override Matrix<double> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<double> result)
		{
		}

		public override Matrix<double> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<double> result)
		{
		}

		public override Matrix<double> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<double> result)
		{
		}

		public override Matrix<double> SubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
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
	}
}
