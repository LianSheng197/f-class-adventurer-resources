using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class ScalarValueObjectiveFunctionEvaluation : IScalarObjectiveFunctionEvaluation
	{
		public double Point
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Value
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Derivative => 0.0;

		public double SecondDerivative => 0.0;

		public ScalarValueObjectiveFunctionEvaluation(double point, double value)
		{
		}
	}
}
