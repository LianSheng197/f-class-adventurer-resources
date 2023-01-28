using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class MlkBiCgStab : IIterativeSolver<System.Numerics.Complex>
	{
		private const int DefaultNumberOfStartingVectors = 50;

		private IList<Vector<System.Numerics.Complex>> _startingVectors;

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

		public IList<Vector<System.Numerics.Complex>> StartingVectors
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

		private static IList<Vector<System.Numerics.Complex>> CreateStartingVectors(int maximumNumberOfStartingVectors, int numberOfVariables)
		{
			return null;
		}

		private static Vector<System.Numerics.Complex>[] CreateVectorArray(int arraySize, int vectorSize)
		{
			return null;
		}

		private static void CalculateTrueResidual(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> residual, Vector<System.Numerics.Complex> x, Vector<System.Numerics.Complex> b)
		{
		}

		public void Solve(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result, Iterator<System.Numerics.Complex> iterator, IPreconditioner<System.Numerics.Complex> preconditioner)
		{
		}
	}
}
