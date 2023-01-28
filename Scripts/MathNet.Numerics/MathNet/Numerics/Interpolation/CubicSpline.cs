using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Interpolation
{
	public class CubicSpline : IInterpolation
	{
		private readonly double[] _x;

		private readonly double[] _c0;

		private readonly double[] _c1;

		private readonly double[] _c2;

		private readonly double[] _c3;

		private readonly Lazy<double[]> _indefiniteIntegral;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsDifferentiation => false;

		private bool MathNet_002ENumerics_002EInterpolation_002EIInterpolation_002ESupportsIntegration => false;

		public CubicSpline(double[] x, double[] c0, double[] c1, double[] c2, double[] c3)
		{
		}

		public static CubicSpline InterpolateHermiteSorted(double[] x, double[] y, double[] firstDerivatives)
		{
			return null;
		}

		public static CubicSpline InterpolateHermiteInplace(double[] x, double[] y, double[] firstDerivatives)
		{
			return null;
		}

		public static CubicSpline InterpolateHermite(IEnumerable<double> x, IEnumerable<double> y, IEnumerable<double> firstDerivatives)
		{
			return null;
		}

		public static CubicSpline InterpolateAkimaSorted(double[] x, double[] y)
		{
			return null;
		}

		public static CubicSpline InterpolateAkimaInplace(double[] x, double[] y)
		{
			return null;
		}

		public static CubicSpline InterpolateAkima(IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		public static CubicSpline InterpolatePchipSorted(double[] x, double[] y)
		{
			return null;
		}

		private static double PchipEndPoints(double h0, double h1, double m0, double m1)
		{
			return 0.0;
		}

		public static CubicSpline InterpolatePchipInplace(double[] x, double[] y)
		{
			return null;
		}

		public static CubicSpline InterpolatePchip(IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		public static CubicSpline InterpolateBoundariesSorted(double[] x, double[] y, SplineBoundaryCondition leftBoundaryCondition, double leftBoundary, SplineBoundaryCondition rightBoundaryCondition, double rightBoundary)
		{
			return null;
		}

		public static CubicSpline InterpolateBoundariesInplace(double[] x, double[] y, SplineBoundaryCondition leftBoundaryCondition, double leftBoundary, SplineBoundaryCondition rightBoundaryCondition, double rightBoundary)
		{
			return null;
		}

		public static CubicSpline InterpolateBoundaries(IEnumerable<double> x, IEnumerable<double> y, SplineBoundaryCondition leftBoundaryCondition, double leftBoundary, SplineBoundaryCondition rightBoundaryCondition, double rightBoundary)
		{
			return null;
		}

		public static CubicSpline InterpolateNaturalSorted(double[] x, double[] y)
		{
			return null;
		}

		public static CubicSpline InterpolateNaturalInplace(double[] x, double[] y)
		{
			return null;
		}

		public static CubicSpline InterpolateNatural(IEnumerable<double> x, IEnumerable<double> y)
		{
			return null;
		}

		private static double DifferentiateThreePoint(double[] xx, double[] yy, int indexT, int index0, int index1, int index2)
		{
			return 0.0;
		}

		private static double[] SolveTridiagonal(double[] a, double[] b, double[] c, double[] d)
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

		public double[] StationaryPoints()
		{
			return null;
		}

		public Tuple<double, double> Extrema()
		{
			return null;
		}
	}
}
