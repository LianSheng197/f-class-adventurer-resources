using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class ILUTPPreconditioner : IPreconditioner<MathNet.Numerics.Complex32>
	{
		public const double DefaultFillLevel = 200.0;

		public const double DefaultDropTolerance = 0.0001;

		private SparseMatrix _upper;

		private SparseMatrix _lower;

		private int[] _pivots;

		private double _fillLevel;

		private double _dropTolerance;

		private double _pivotTolerance;

		public double FillLevel
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double DropTolerance
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double PivotTolerance
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public ILUTPPreconditioner()
		{
		}

		public ILUTPPreconditioner(double fillLevel, double dropTolerance, double pivotTolerance)
		{
		}

		internal Matrix<MathNet.Numerics.Complex32> UpperTriangle()
		{
			return null;
		}

		internal Matrix<MathNet.Numerics.Complex32> LowerTriangle()
		{
			return null;
		}

		internal int[] Pivots()
		{
			return null;
		}

		public void Initialize(Matrix<MathNet.Numerics.Complex32> matrix)
		{
		}

		private void PivotRow(Vector<MathNet.Numerics.Complex32> row)
		{
		}

		private bool PivotMapFound(Dictionary<int, int> knownPivots, int currentItem)
		{
			return false;
		}

		private static void SwapColumns(Matrix<MathNet.Numerics.Complex32> matrix, int firstColumn, int secondColumn)
		{
		}

		private static void FindLargestItems(int lowerBound, int upperBound, int[] sortedIndices, Vector<MathNet.Numerics.Complex32> values)
		{
		}

		public void Approximate(Vector<MathNet.Numerics.Complex32> rhs, Vector<MathNet.Numerics.Complex32> lhs)
		{
		}

		private void Pivot(Vector<MathNet.Numerics.Complex32> vector, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
