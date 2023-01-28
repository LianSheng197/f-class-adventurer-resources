using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class TransformedInterpolation : IInterpolation
	{
		private readonly IInterpolation _interpolation;

		private readonly Func<double, double> _transform;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public TransformedInterpolation(IInterpolation interpolation, Func<double, double> transform)
		{
		}

		public static TransformedInterpolation InterpolateSorted(Func<double, double> transform, Func<double, double> transformInverse, double[] x, double[] y)
		{
			return null;
		}

		public static TransformedInterpolation InterpolateInplace(Func<double, double> transform, Func<double, double> transformInverse, double[] x, double[] y)
		{
			return null;
		}

		public static TransformedInterpolation Interpolate(Func<double, double> transform, Func<double, double> transformInverse, IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		public double Interpolate(double t)
		{
			return 0.0;
		}

		private double MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002EDifferentiate(double t)
		{
			return 0.0;
		}

		private double MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002EDifferentiate2(double t)
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
