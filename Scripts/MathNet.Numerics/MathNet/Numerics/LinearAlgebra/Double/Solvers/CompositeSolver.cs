using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class CompositeSolver : IIterativeSolver<double>
	{
		private readonly List<Tuple<IIterativeSolver<double>, IPreconditioner<double>>> _solvers;

		public CompositeSolver(IEnumerable<IIterativeSolverSetup<double>> solvers)
		{
		}

		public void Solve(Matrix<double> matrix, Vector<double> input, Vector<double> result, Iterator<double> iterator, IPreconditioner<double> preconditioner)
		{
		}
	}
}
