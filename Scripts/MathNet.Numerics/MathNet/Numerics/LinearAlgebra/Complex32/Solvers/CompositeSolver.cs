using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class CompositeSolver : IIterativeSolver<MathNet.Numerics.Complex32>
	{
		private readonly List<Tuple<IIterativeSolver<MathNet.Numerics.Complex32>, IPreconditioner<MathNet.Numerics.Complex32>>> _solvers;

		public CompositeSolver(IEnumerable<IIterativeSolverSetup<MathNet.Numerics.Complex32>> solvers)
		{
		}

		public void Solve(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result, Iterator<MathNet.Numerics.Complex32> iterator, IPreconditioner<MathNet.Numerics.Complex32> preconditioner)
		{
		}
	}
}
