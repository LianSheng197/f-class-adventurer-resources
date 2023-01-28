using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class TFQMR : IIterativeSolver<MathNet.Numerics.Complex32>
	{
		private static void CalculateTrueResidual(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> residual, Vector<MathNet.Numerics.Complex32> x, Vector<MathNet.Numerics.Complex32> b)
		{
		}

		private static bool IsEven(int number)
		{
			return false;
		}

		public void Solve(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result, Iterator<MathNet.Numerics.Complex32> iterator, IPreconditioner<MathNet.Numerics.Complex32> preconditioner)
		{
		}
	}
}
