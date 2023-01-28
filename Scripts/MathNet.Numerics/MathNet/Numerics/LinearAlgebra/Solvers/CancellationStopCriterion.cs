using System;
using System.Diagnostics;
using System.Threading;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class CancellationStopCriterion<T> : IIterationStopCriterion<T> where T : struct, IEquatable<T>, IFormattable
	{
		private readonly CancellationToken _masterToken;

		private CancellationTokenSource _currentTcs;

		public IterationStatus Status
		{
			[DebuggerStepThrough]
			get
			{
				return default(IterationStatus);
			}
		}

		public CancellationStopCriterion()
		{
		}

		public CancellationStopCriterion(CancellationToken masterToken)
		{
		}

		public IterationStatus DetermineStatus(int iterationNumber, Vector<T> solutionVector, Vector<T> sourceVector, Vector<T> residualVector)
		{
			return default(IterationStatus);
		}

		public void Cancel()
		{
		}

		public void Reset()
		{
		}

		public IIterationStopCriterion<T> Clone()
		{
			return null;
		}
	}
}
