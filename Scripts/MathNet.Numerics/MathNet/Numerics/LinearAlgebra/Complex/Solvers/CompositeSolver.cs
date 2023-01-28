using System;
using System.Collections.Generic;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class CompositeSolver : IIterativeSolver<System.Numerics.Complex>
	{
		private readonly List<Tuple<IIterativeSolver<System.Numerics.Complex>, IPreconditioner<System.Numerics.Complex>>> _solvers;

		public CompositeSolver(IEnumerable<IIterativeSolverSetup<System.Numerics.Complex>> solvers)
		{
		}

		public void Solve(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result, Iterator<System.Numerics.Complex> iterator, IPreconditioner<System.Numerics.Complex> preconditioner)
		{
		}
	}
}
