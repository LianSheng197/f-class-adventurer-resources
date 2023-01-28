using System;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.OdeSolvers
{
	public static class RungeKutta
	{
		public static double[] SecondOrder(double y0, double start, double end, int N, Func<double, double, double> f)
		{
			return null;
		}

		public static double[] FourthOrder(double y0, double start, double end, int N, Func<double, double, double> f)
		{
			return null;
		}

		public static Vector<double>[] SecondOrder(Vector<double> y0, double start, double end, int N, Func<double, Vector<double>, Vector<double>> f)
		{
			return null;
		}

		public static Vector<double>[] FourthOrder(Vector<double> y0, double start, double end, int N, Func<double, Vector<double>, Vector<double>> f)
		{
			return null;
		}
	}
}
