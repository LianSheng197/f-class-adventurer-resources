using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class Barycentric : IInterpolation
	{
		private readonly double[] _x;

		private readonly double[] _y;

		private readonly double[] _w;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public Barycentric(double[] x, double[] y, double[] w)
		{
		}

		public static Barycentric InterpolatePolynomialEquidistantSorted(double[] x, double[] y)
		{
			return null;
		}

		public static Barycentric InterpolatePolynomialEquidistantInplace(double[] x, double[] y)
		{
			return null;
		}

		public static Barycentric InterpolatePolynomialEquidistant(IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		public static Barycentric InterpolatePolynomialEquidistant(double leftBound, double rightBound, IEnumerable<double> y)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormannSorted(double[] x, double[] y, int order)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormannInplace(double[] x, double[] y, int order)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormann(IEnumerable<double> x, IEnumerable<double> y, int order)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormannSorted(double[] x, double[] y)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormannInplace(double[] x, double[] y)
		{
			return null;
		}

		public static Barycentric InterpolateRationalFloaterHormann(IEnumerable<double> x, IEnumerable<double> y)
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
