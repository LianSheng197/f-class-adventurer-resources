using System;
using System.Diagnostics;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public sealed class DivergenceStopCriterion<T> : IIterationStopCriterion<T> where T : struct, IEquatable<T>, IFormattable
	{
		private double _maximumRelativeIncrease;

		private int _minimumNumberOfIterations;

		private IterationStatus _status;

		private double[] _residualHistory;

		private int _lastIteration;

		public double MaximumRelativeIncrease
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

		public int MinimumNumberOfIterations
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

		private int RequiredHistoryLength
		{
			[DebuggerStepThrough]
			get
			{
				return 0;
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

		public DivergenceStopCriterion(double maximumRelativeIncrease = 0.08, int minimumIterations = 10)
		{
		}

		public IterationStatus DetermineStatus(int iterationNumber, Vector<T> solutionVector, Vector<T> sourceVector, Vector<T> residualVector)
		{
			return default(IterationStatus);
		}

		private bool IsDiverging()
		{
			return false;
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
