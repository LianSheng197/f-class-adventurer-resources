using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class NevillePolynomialInterpolation : IInterpolation
	{
		private readonly double[] _x;

		private readonly double[] _y;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public NevillePolynomialInterpolation(double[] x, double[] y)
		{
		}

		public static NevillePolynomialInterpolation InterpolateSorted(double[] x, double[] y)
		{
			return null;
		}

		public static NevillePolynomialInterpolation InterpolateInplace(double[] x, double[] y)
		{
			return null;
		}

		public static NevillePolynomialInterpolation Interpolate(IEnumerable<double> x, IEnumerable<double> y)
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
