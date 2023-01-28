using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class CompositeSolver : IIterativeSolver<float>
	{
		private readonly List<Tuple<IIterativeSolver<float>, IPreconditioner<float>>> _solvers;

		public CompositeSolver(IEnumerable<IIterativeSolverSetup<float>> solvers)
		{
		}

		public void Solve(Matrix<float> matrix, Vector<float> input, Vector<float> result, Iterator<float> iterator, IPreconditioner<float> preconditioner)
		{
		}
	}
}
