using System;
using System.Collections.Generic;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class Iterator<T> where T : struct, IEquatable<T>, IFormattable
	{
		private readonly List<IIterationStopCriterion<T>> _stopCriteria;

		private IterationStatus _status;

		public IterationStatus Status => default(IterationStatus);

		public Iterator()
		{
		}

		public Iterator(params IIterationStopCriterion<T>[] stopCriteria)
		{
		}

		public Iterator(IEnumerable<IIterationStopCriterion<T>> stopCriteria)
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

		public Iterator<T> Clone()
		{
			return null;
		}
	}
}
