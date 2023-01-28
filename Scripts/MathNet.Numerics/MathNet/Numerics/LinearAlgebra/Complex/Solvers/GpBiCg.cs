using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class GpBiCg : IIterativeSolver<System.Numerics.Complex>
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

		private static void CalculateTrueResidual(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> residual, Vector<System.Numerics.Complex> x, Vector<System.Numerics.Complex> b)
		{
		}

		private bool ShouldRunBiCgStabSteps(int iterationNumber)
		{
			return false;
		}

		public void Solve(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result, Iterator<System.Numerics.Complex> iterator, IPreconditioner<System.Numerics.Complex> preconditioner)
		{
		}
	}
}
