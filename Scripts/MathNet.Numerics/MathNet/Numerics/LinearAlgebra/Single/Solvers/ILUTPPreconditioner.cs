using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class ILUTPPreconditioner : IPreconditioner<float>
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

		internal Matrix<float> UpperTriangle()
		{
			return null;
		}

		internal Matrix<float> LowerTriangle()
		{
			return null;
		}

		internal int[] Pivots()
		{
			return null;
		}

		public void Initialize(Matrix<float> matrix)
		{
		}

		private void PivotRow(Vector<float> row)
		{
		}

		private bool PivotMapFound(Dictionary<int, int> knownPivots, int currentItem)
		{
			return false;
		}

		private static void SwapColumns(Matrix<float> matrix, int firstColumn, int secondColumn)
		{
		}

		private static void FindLargestItems(int lowerBound, int upperBound, int[] sortedIndices, Vector<float> values)
		{
		}

		public void Approximate(Vector<float> rhs, Vector<float> lhs)
		{
		}

		private void Pivot(Vector<float> vector, Vector<float> result)
		{
		}
	}
}
