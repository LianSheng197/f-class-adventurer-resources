using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class ILUTPPreconditioner : IPreconditioner<double>
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

		internal Matrix<double> UpperTriangle()
		{
			return null;
		}

		internal Matrix<double> LowerTriangle()
		{
			return null;
		}

		internal int[] Pivots()
		{
			return null;
		}

		public void Initialize(Matrix<double> matrix)
		{
		}

		private void PivotRow(Vector<double> row)
		{
		}

		private bool PivotMapFound(Dictionary<int, int> knownPivots, int currentItem)
		{
			return false;
		}

		private static void SwapColumns(Matrix<double> matrix, int firstColumn, int secondColumn)
		{
		}

		private static void FindLargestItems(int lowerBound, int upperBound, int[] sortedIndices, Vector<double> values)
		{
		}

		public void Approximate(Vector<double> rhs, Vector<double> lhs)
		{
		}

		private void Pivot(Vector<double> vector, Vector<double> result)
		{
		}
	}
}
