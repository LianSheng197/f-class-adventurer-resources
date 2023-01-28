using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	internal class MatrixBuilder : MatrixBuilder<float>
	{
		public override float Zero => 0f;

		public override float One => 0f;

		public override Matrix<float> Dense(DenseColumnMajorMatrixStorage<float> storage)
		{
			return null;
		}

		public override Matrix<float> Sparse(SparseCompressedRowMatrixStorage<float> storage)
		{
			return null;
		}

		public override Matrix<float> Diagonal(DiagonalMatrixStorage<float> storage)
		{
			return null;
		}

		public override Matrix<float> Random(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		public override IIterationStopCriterion<float>[] IterativeSolverStopCriteria(int maxIterations = 1000)
		{
			return null;
		}

		internal override float Add(float x, float y)
		{
			return 0f;
		}

		public MatrixBuilder()
		{
			((MatrixBuilder<>)(object)this)._002Ector();
		}
	}
}
