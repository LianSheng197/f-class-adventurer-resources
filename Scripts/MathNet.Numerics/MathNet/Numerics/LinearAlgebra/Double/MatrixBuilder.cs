using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	internal class MatrixBuilder : MatrixBuilder<double>
	{
		public override double Zero => 0.0;

		public override double One => 0.0;

		public override Matrix<double> Dense(DenseColumnMajorMatrixStorage<double> storage)
		{
			return null;
		}

		public override Matrix<double> Sparse(SparseCompressedRowMatrixStorage<double> storage)
		{
			return null;
		}

		public override Matrix<double> Diagonal(DiagonalMatrixStorage<double> storage)
		{
			return null;
		}

		public override Matrix<double> Random(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		public override IIterationStopCriterion<double>[] IterativeSolverStopCriteria(int maxIterations = 1000)
		{
			return null;
		}

		internal override double Add(double x, double y)
		{
			return 0.0;
		}

		public MatrixBuilder()
		{
			((MatrixBuilder<>)(object)this)._002Ector();
		}
	}
}
