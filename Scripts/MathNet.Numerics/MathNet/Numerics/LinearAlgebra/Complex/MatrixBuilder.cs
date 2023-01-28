using System.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	internal class MatrixBuilder : MatrixBuilder<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Zero => default(System.Numerics.Complex);

		public override System.Numerics.Complex One => default(System.Numerics.Complex);

		public override Matrix<System.Numerics.Complex> Dense(DenseColumnMajorMatrixStorage<System.Numerics.Complex> storage)
		{
			return null;
		}

		public override Matrix<System.Numerics.Complex> Sparse(SparseCompressedRowMatrixStorage<System.Numerics.Complex> storage)
		{
			return null;
		}

		public override Matrix<System.Numerics.Complex> Diagonal(DiagonalMatrixStorage<System.Numerics.Complex> storage)
		{
			return null;
		}

		public override Matrix<System.Numerics.Complex> Random(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		public override IIterationStopCriterion<System.Numerics.Complex>[] IterativeSolverStopCriteria(int maxIterations = 1000)
		{
			return null;
		}

		internal override System.Numerics.Complex Add(System.Numerics.Complex x, System.Numerics.Complex y)
		{
			return default(System.Numerics.Complex);
		}

		public MatrixBuilder()
		{
			((MatrixBuilder<>)(object)this)._002Ector();
		}
	}
}
