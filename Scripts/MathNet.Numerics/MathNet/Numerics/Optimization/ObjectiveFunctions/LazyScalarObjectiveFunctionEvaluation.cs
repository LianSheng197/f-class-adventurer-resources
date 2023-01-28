namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class LazyScalarObjectiveFunctionEvaluation : IScalarObjectiveFunctionEvaluation
	{
		private double? _value;

		private double? _derivative;

		private double? _secondDerivative;

		private readonly ScalarObjectiveFunction _objectiveObject;

		private readonly double _point;

		public double Point => 0.0;

		public double Value => 0.0;

		public double Derivative => 0.0;

		public double SecondDerivative => 0.0;

		public LazyScalarObjectiveFunctionEvaluation(ScalarObjectiveFunction f, double point)
		{
		}

		private double SetValue()
		{
			return 0.0;
		}

		private double SetDerivative()
		{
			return 0.0;
		}

		private double SetSecondDerivative()
		{
			return 0.0;
		}
	}
}
