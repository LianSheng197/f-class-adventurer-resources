using System;
using System.Diagnostics;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class ResidualStopCriterion<T> : IIterationStopCriterion<T> where T : struct, IEquatable<T>, IFormattable
	{
		private double _maximum;

		private int _minimumIterationsBelowMaximum;

		private IterationStatus _status;

		private int _iterationCount;

		private int _lastIteration;

		public double Maximum
		{
			[DebuggerStepThrough]
			get
			{
				return 0.0;
			}
			[DebuggerStepThrough]
			set
			{
			}
		}

		public int MinimumIterationsBelowMaximum
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

		public ResidualStopCriterion(double maximum, int minimumIterationsBelowMaximum = 0)
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
