using System;
using System.Numerics;
using MathNet.Numerics.Integration.GaussRule;

namespace MathNet.Numerics.Integration
{
	public class GaussLegendreRule
	{
		private readonly GaussPoint _gaussLegendrePoint;

		public double[] Abscissas => null;

		public double[] Weights => null;

		public int Order => 0;

		public double IntervalBegin => 0.0;

		public double IntervalEnd => 0.0;

		public GaussLegendreRule(double intervalBegin, double intervalEnd, int order)
		{
		}

		public double GetAbscissa(int index)
		{
			return 0.0;
		}

		public double GetWeight(int index)
		{
			return 0.0;
		}

		public static double Integrate(Func<double, double> f, double invervalBegin, double invervalEnd, int order)
		{
			return 0.0;
		}

		public static Complex ContourIntegrate(Func<double, Complex> f, double invervalBegin, double invervalEnd, int order)
		{
			return default(Complex);
		}

		public static double Integrate(Func<double, double, double> f, double invervalBeginA, double invervalEndA, double invervalBeginB, double invervalEndB, int order)
		{
			return 0.0;
		}
	}
}
