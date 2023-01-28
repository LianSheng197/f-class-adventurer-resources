using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	internal class MatrixBuilder : MatrixBuilder<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Zero => default(MathNet.Numerics.Complex32);

		public override MathNet.Numerics.Complex32 One => default(MathNet.Numerics.Complex32);

		public override Matrix<MathNet.Numerics.Complex32> Dense(DenseColumnMajorMatrixStorage<MathNet.Numerics.Complex32> storage)
		{
			return null;
		}

		public override Matrix<MathNet.Numerics.Complex32> Sparse(SparseCompressedRowMatrixStorage<MathNet.Numerics.Complex32> storage)
		{
			return null;
		}

		public override Matrix<MathNet.Numerics.Complex32> Diagonal(DiagonalMatrixStorage<MathNet.Numerics.Complex32> storage)
		{
			return null;
		}

		public override Matrix<MathNet.Numerics.Complex32> Random(int rows, int columns, IContinuousDistribution distribution)
		{
			return null;
		}

		public override IIterationStopCriterion<MathNet.Numerics.Complex32>[] IterativeSolverStopCriteria(int maxIterations = 1000)
		{
			return null;
		}

		internal override MathNet.Numerics.Complex32 Add(MathNet.Numerics.Complex32 x, MathNet.Numerics.Complex32 y)
		{
			return default(MathNet.Numerics.Complex32);
		}

		public MatrixBuilder()
		{
			((MatrixBuilder<>)(object)this)._002Ector();
		}
	}
}
