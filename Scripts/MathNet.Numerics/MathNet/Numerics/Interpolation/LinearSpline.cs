using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class LinearSpline : IInterpolation
	{
		private readonly double[] _x;

		private readonly double[] _c0;

		private readonly double[] _c1;

		private readonly Lazy<double[]> _indefiniteIntegral;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public LinearSpline(double[] x, double[] c0, double[] c1)
		{
		}

		public static LinearSpline InterpolateSorted(double[] x, double[] y)
		{
			return null;
		}

		public static LinearSpline InterpolateInplace(double[] x, double[] y)
		{
			return null;
		}

		public static LinearSpline Interpolate(IEnumerable<double> x, IEnumerable<double> y)
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

		public double Integrate(double t)
		{
			return 0.0;
		}

		public double Integrate(double a, double b)
		{
			return 0.0;
		}

		private double[] ComputeIndefiniteIntegral()
		{
			return null;
		}

		private int LeftSegmentIndex(double t)
		{
			return 0;
		}
	}
}
