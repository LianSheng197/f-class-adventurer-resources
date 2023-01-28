using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class LogLinear : IInterpolation
	{
		private readonly LinearSpline _spline;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public LogLinear(double[] x, double[] logy)
		{
		}

		public static LogLinear InterpolateSorted(double[] x, double[] y)
		{
			return null;
		}

		public static LogLinear InterpolateInplace(double[] x, double[] y)
		{
			return null;
		}

		public static LogLinear Interpolate(IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		public double Interpolate(double t)
		{
			return 0.0;
		}

		public double Differentiate(double t)
		{
			return 0.0;
		}

		public double Differentiate2(double t)
		{
			return 0.0;
		}

		private double MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002EIntegrate(double t)
		{
			return 0.0;
		}

		private double MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002EIntegrate(double a, double b)
		{
			return 0.0;
		}
	}
}
