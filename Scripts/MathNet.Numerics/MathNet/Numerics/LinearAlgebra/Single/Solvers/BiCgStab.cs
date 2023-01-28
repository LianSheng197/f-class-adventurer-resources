using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class BiCgStab : IIterativeSolver<float>
	{
		private static void CalculateTrueResidual(Matrix<float> matrix, Vector<float> residual, Vector<float> x, Vector<float> b)
		{
		}

		public void Solve(Matrix<float> matrix, Vector<float> input, Vector<float> result, Iterator<float> iterator, IPreconditioner<float> preconditioner)
		{
		}
	}
}
