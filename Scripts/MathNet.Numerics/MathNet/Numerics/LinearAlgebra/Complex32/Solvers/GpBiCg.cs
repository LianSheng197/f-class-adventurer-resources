using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class GpBiCg : IIterativeSolver<MathNet.Numerics.Complex32>
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

		private static void CalculateTrueResidual(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> residual, Vector<MathNet.Numerics.Complex32> x, Vector<MathNet.Numerics.Complex32> b)
		{
		}

		private bool ShouldRunBiCgStabSteps(int iterationNumber)
		{
			return false;
		}

		public void Solve(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result, Iterator<MathNet.Numerics.Complex32> iterator, IPreconditioner<MathNet.Numerics.Complex32> preconditioner)
		{
		}
	}
}
