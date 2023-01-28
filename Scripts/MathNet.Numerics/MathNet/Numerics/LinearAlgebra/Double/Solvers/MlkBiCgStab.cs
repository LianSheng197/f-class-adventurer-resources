using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class MlkBiCgStab : IIterativeSolver<double>
	{
		private const int DefaultNumberOfStartingVectors = 50;

		private IList<Vector<double>> _startingVectors;

		private int _numberOfStartingVectors;

		public int NumberOfStartingVectors
		{
			[DebuggerStepThrough]
			get
			{
				return 0;
			}
			[DebuggerStepThrough]
			set
			{
			}
		}

		public IList<Vector<double>> StartingVectors
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[DebuggerStepThrough]
			set
			{
			}
		}

		public void ResetNumberOfStartingVectors()
		{
		}

		private static int NumberOfStartingVectorsToCreate(int maximumNumberOfStartingVectors, int numberOfVariables)
		{
			return 0;
		}

		private static IList<Vector<double>> CreateStartingVectors(int maximumNumberOfStartingVectors, int numberOfVariables)
		{
			return null;
		}

		private static Vector<double>[] CreateVectorArray(int arraySize, int vectorSize)
		{
			return null;
		}

		private static void CalculateTrueResidual(Matrix<double> matrix, Vector<double> residual, Vector<double> x, Vector<double> b)
		{
		}

		public void Solve(Matrix<double> matrix, Vector<double> input, Vector<double> result, Iterator<double> iterator, IPreconditioner<double> preconditioner)
		{
		}
	}
}
