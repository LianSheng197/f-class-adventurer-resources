using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class GpBiCg : IIterativeSolver<double>
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

		private static void CalculateTrueResidual(Matrix<double> matrix, Vector<double> residual, Vector<double> x, Vector<double> b)
		{
		}

		private bool ShouldRunBiCgStabSteps(int iterationNumber)
		{
			return false;
		}

		public void Solve(Matrix<double> matrix, Vector<double> input, Vector<double> result, Iterator<double> iterator, IPreconditioner<double> preconditioner)
		{
		}
	}
}
