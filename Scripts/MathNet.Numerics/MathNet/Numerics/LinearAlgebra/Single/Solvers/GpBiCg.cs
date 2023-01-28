using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class GpBiCg : IIterativeSolver<float>
	{
		private int _numberOfBiCgStabSteps;

		private int _numberOfGpbiCgSteps;

		public int NumberOfBiCgStabSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NumberOfGpBiCgSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private static void CalculateTrueResidual(Matrix<float> matrix, Vector<float> residual, Vector<float> x, Vector<float> b)
		{
		}

		private bool ShouldRunBiCgStabSteps(int iterationNumber)
		{
			return false;
		}

		public void Solve(Matrix<float> matrix, Vector<float> input, Vector<float> result, Iterator<float> iterator, IPreconditioner<float> preconditioner)
		{
		}
	}
}
