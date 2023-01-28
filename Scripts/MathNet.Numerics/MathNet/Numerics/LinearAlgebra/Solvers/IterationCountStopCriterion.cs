using System;
using System.Diagnostics;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class IterationCountStopCriterion<T> : IIterationStopCriterion<T> where T : struct, IEquatable<T>, IFormattable
	{
		public const int DefaultMaximumNumberOfIterations = 1000;

		private int _maximumNumberOfIterations;

		private IterationStatus _status;

		public int MaximumNumberOfIterations
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

		public IterationStatus Status
		{
			[DebuggerStepThrough]
			get
			{
				return default(IterationStatus);
			}
		}

		public IterationCountStopCriterion()
		{
		}

		public IterationCountStopCriterion(int maximumNumberOfIterations)
		{
		}

		public void ResetMaximumNumberOfIterationsToDefault()
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
