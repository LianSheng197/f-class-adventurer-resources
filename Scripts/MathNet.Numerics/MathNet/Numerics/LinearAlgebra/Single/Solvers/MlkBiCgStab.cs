using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class MlkBiCgStab : IIterativeSolver<float>
	{
		private const int DefaultNumberOfStartingVectors = 50;

		private IList<Vector<float>> _startingVectors;

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

		public IList<Vector<float>> StartingVectors
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

		private static IList<Vector<float>> CreateStartingVectors(int maximumNumberOfStartingVectors, int numberOfVariables)
		{
			return null;
		}

		private static Vector<float>[] CreateVectorArray(int arraySize, int vectorSize)
		{
			return null;
		}

		private static void CalculateTrueResidual(Matrix<float> matrix, Vector<float> residual, Vector<float> x, Vector<float> b)
		{
		}

		public void Solve(Matrix<float> matrix, Vector<float> input, Vector<float> result, Iterator<float> iterator, IPreconditioner<float> preconditioner)
		{
		}
	}
}
