using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class MlkBiCgStab : IIterativeSolver<MathNet.Numerics.Complex32>
	{
		private const int DefaultNumberOfStartingVectors = 50;

		private IList<Vector<MathNet.Numerics.Complex32>> _startingVectors;

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

		public IList<Vector<MathNet.Numerics.Complex32>> StartingVectors
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

		private static IList<Vector<MathNet.Numerics.Complex32>> CreateStartingVectors(int maximumNumberOfStartingVectors, int numberOfVariables)
		{
			return null;
		}

		private static Vector<MathNet.Numerics.Complex32>[] CreateVectorArray(int arraySize, int vectorSize)
		{
			return null;
		}

		private static void CalculateTrueResidual(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> residual, Vector<MathNet.Numerics.Complex32> x, Vector<MathNet.Numerics.Complex32> b)
		{
		}

		public void Solve(Matrix<MathNet.Numerics.Complex32> matrix, Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result, Iterator<MathNet.Numerics.Complex32> iterator, IPreconditioner<MathNet.Numerics.Complex32> preconditioner)
		{
		}
	}
}
