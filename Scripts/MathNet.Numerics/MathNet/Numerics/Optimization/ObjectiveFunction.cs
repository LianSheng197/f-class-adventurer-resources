using System;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public static class ObjectiveFunction
	{
		public static IObjectiveFunction Value(Func<Vector<double>, double> function)
		{
			return null;
		}

		public static IObjectiveFunction Gradient(Func<Vector<double>, (double, Vector<double>)> function)
		{
			return null;
		}

		public static IObjectiveFunction Gradient(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient)
		{
			return null;
		}

		public static IObjectiveFunction Hessian(Func<Vector<double>, (double, Matrix<double>)> function)
		{
			return null;
		}

		public static IObjectiveFunction Hessian(Func<Vector<double>, double> function, Func<Vector<double>, Matrix<double>> hessian)
		{
			return null;
		}

		public static IObjectiveFunction GradientHessian(Func<Vector<double>, (double, Vector<double>, Matrix<double>)> function)
		{
			return null;
		}

		public static IObjectiveFunction GradientHessian(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient, Func<Vector<double>, Matrix<double>> hessian)
		{
			return null;
		}

		public static IScalarObjectiveFunction ScalarValue(Func<double, double> function)
		{
			return null;
		}

		public static IScalarObjectiveFunction ScalarDerivative(Func<double, double> function, Func<double, double> derivative)
		{
			return null;
		}

		public static IScalarObjectiveFunction ScalarSecondDerivative(Func<double, double> function, Func<double, double> derivative, Func<double, double> secondDerivative)
		{
			return null;
		}

		public static IObjectiveModel NonlinearModel(Func<Vector<double>, Vector<double>, Vector<double>> function, Func<Vector<double>, Vector<double>, Matrix<double>> derivatives, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null)
		{
			return null;
		}

		public static IObjectiveModel NonlinearModel(Func<Vector<double>, Vector<double>, Vector<double>> function, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null, int accuracyOrder = 2)
		{
			return null;
		}

		public static IObjectiveModel NonlinearModel(Func<Vector<double>, double, double> function, Func<Vector<double>, double, Vector<double>> derivatives, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null)
		{
			return null;
		}

		public static IObjectiveModel NonlinearModel(Func<Vector<double>, double, double> function, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null, int accuracyOrder = 2)
		{
			return null;
		}

		public static IObjectiveFunction NonlinearFunction(Func<Vector<double>, Vector<double>, Vector<double>> function, Func<Vector<double>, Vector<double>, Matrix<double>> derivatives, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null)
		{
			return null;
		}

		public static IObjectiveFunction NonlinearFunction(Func<Vector<double>, Vector<double>, Vector<double>> function, Vector<double> observedX, Vector<double> observedY, Vector<double> weight = null, int accuracyOrder = 2)
		{
			return null;
		}
	}
}
