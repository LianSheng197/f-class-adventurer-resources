using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	[DebuggerDisplay("DiagonalMatrix {RowCount}x{ColumnCount}-Single")]
	public class DiagonalMatrix : Matrix
	{
		private readonly float[] _data;

		public DiagonalMatrix(DiagonalMatrixStorage<float> storage)
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

		public DiagonalMatrix(int rows, int columns, float diagonalValue)
			: base(null)
		{
		}

		public DiagonalMatrix(int rows, int columns, float[] diagonalStorage)
			: base(null)
		{
		}

		public static DiagonalMatrix OfMatrix(Matrix<float> matrix)
		{
			return null;
		}

		public static DiagonalMatrix OfArray(float[,] array)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<Tuple<int, float>> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfIndexedDiagonal(int rows, int columns, IEnumerable<(int, float)> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix OfDiagonal(int rows, int columns, IEnumerable<float> diagonal)
		{
			return null;
		}

		public static DiagonalMatrix Create(int rows, int columns, Func<int, float> init)
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

		protected override void DoNegate(Matrix<float> result)
		{
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

		protected override void DoMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoDivide(float divisor, Matrix<float> result)
		{
		}

		protected override void DoDivideByThis(float dividend, Matrix<float> result)
		{
		}

		public override float Determinant()
		{
			return 0f;
		}

		public override Vector<float> Diagonal()
		{
			return null;
		}

		public override void SetDiagonal(float[] source)
		{
		}

		public override void SetDiagonal(Vector<float> source)
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

		public override float ConditionNumber()
		{
			return 0f;
		}

		public override Matrix<float> Inverse()
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

		public override Matrix<float> StrictlyLowerTriangle()
		{
			return null;
		}

		public override void StrictlyLowerTriangle(Matrix<float> result)
		{
		}

		public override Matrix<float> UpperTriangle()
		{
			return null;
		}

		public override void UpperTriangle(Matrix<float> result)
		{
		}

		public override Matrix<float> StrictlyUpperTriangle()
		{
			return null;
		}

		public override void StrictlyUpperTriangle(Matrix<float> result)
		{
		}

		public override Matrix<float> SubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
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
	}
}
