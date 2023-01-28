using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class LimitedMemoryBfgsMinimizer : MinimizerBase, IUnconstrainedMinimizer
	{
		public int Memory
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LimitedMemoryBfgsMinimizer(double gradientTolerance, double parameterTolerance, double functionProgressTolerance, int memory, int maximumIterations = 1000)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objective, Vector<double> initialGuess)
		{
			return null;
		}

		private Vector<double> ApplyLbfgsUpdate(IObjectiveFunction previousPoint, List<Vector<double>> ykhistory, List<Vector<double>> skhistory, List<double> rhokhistory)
		{
			return null;
		}
	}
}
