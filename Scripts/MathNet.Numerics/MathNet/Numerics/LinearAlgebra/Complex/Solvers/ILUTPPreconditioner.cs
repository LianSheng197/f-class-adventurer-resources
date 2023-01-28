using System.Collections.Generic;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class ILUTPPreconditioner : IPreconditioner<System.Numerics.Complex>
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

		internal Matrix<System.Numerics.Complex> UpperTriangle()
		{
			return null;
		}

		internal Matrix<System.Numerics.Complex> LowerTriangle()
		{
			return null;
		}

		internal int[] Pivots()
		{
			return null;
		}

		public void Initialize(Matrix<System.Numerics.Complex> matrix)
		{
		}

		private void PivotRow(Vector<System.Numerics.Complex> row)
		{
		}

		private bool PivotMapFound(Dictionary<int, int> knownPivots, int currentItem)
		{
			return false;
		}

		private static void SwapColumns(Matrix<System.Numerics.Complex> matrix, int firstColumn, int secondColumn)
		{
		}

		private static void FindLargestItems(int lowerBound, int upperBound, int[] sortedIndices, Vector<System.Numerics.Complex> values)
		{
		}

		public void Approximate(Vector<System.Numerics.Complex> rhs, Vector<System.Numerics.Complex> lhs)
		{
		}

		private void Pivot(Vector<System.Numerics.Complex> vector, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
