using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class StepInterpolation : IInterpolation
	{
		private readonly double[] _x;

		private readonly double[] _y;

		private readonly Lazy<double[]> _indefiniteIntegral;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public StepInterpolation(double[] x, double[] sy)
		{
		}

		public static StepInterpolation InterpolateSorted(double[] x, double[] y)
		{
			return null;
		}

		public static StepInterpolation InterpolateInplace(double[] x, double[] y)
		{
			return null;
		}

		public static StepInterpolation Interpolate(IEnumerable<double> x, IEnumerable<double> y)
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

		private int LeftBracketIndex(double t)
		{
			return 0;
		}
	}
}
