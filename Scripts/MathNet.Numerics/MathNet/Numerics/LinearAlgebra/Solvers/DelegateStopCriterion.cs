using System;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public class DelegateStopCriterion<T> : IIterationStopCriterion<T> where T : struct, IEquatable<T>, IFormattable
	{
		private readonly Func<int, Vector<T>, Vector<T>, Vector<T>, IterationStatus> _determine;

		private IterationStatus _status;

		public IterationStatus Status => default(IterationStatus);

		public DelegateStopCriterion(Func<int, Vector<T>, Vector<T>, Vector<T>, IterationStatus> determine)
		{
		}

		public IterationStatus DetermineStatus(int iterationNumber, Vector<T> solutionVector, Vector<T> sourceVector, Vector<T> residualVector)
		{
			return default(IterationStatus);
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
