using System;
using System.Collections.Generic;
using System.Numerics;

namespace MathNet.Numerics.Integration
{
	public static class NewtonCotesTrapeziumRule
	{
		public static double IntegrateTwoPoint(Func<double, double> f, double intervalBegin, double intervalEnd)
		{
			return 0.0;
		}

		public static Complex ContourIntegrateTwoPoint(Func<double, Complex> f, double intervalBegin, double intervalEnd)
		{
			return default(Complex);
		}

		public static double IntegrateComposite(Func<double, double> f, double intervalBegin, double intervalEnd, int numberOfPartitions)
		{
			return 0.0;
		}

		public static Complex ContourIntegrateComposite(Func<double, Complex> f, double intervalBegin, double intervalEnd, int numberOfPartitions)
		{
			return default(Complex);
		}

		public static double IntegrateAdaptive(Func<double, double> f, double intervalBegin, double intervalEnd, double targetError)
		{
			return 0.0;
		}

		public static Complex ContourIntegrateAdaptive(Func<double, Complex> f, double intervalBegin, double intervalEnd, double targetError)
		{
			return default(Complex);
		}

		public static double IntegrateAdaptiveTransformedOdd(Func<double, double> f, double intervalBegin, double intervalEnd, IEnumerable<double[]> levelAbscissas, IEnumerable<double[]> levelWeights, double levelOneStep, double targetRelativeError)
		{
			return 0.0;
		}

		public static Complex ContourIntegrateAdaptiveTransformedOdd(Func<double, Complex> f, double intervalBegin, double intervalEnd, IEnumerable<double[]> levelAbscissas, IEnumerable<double[]> levelWeights, double levelOneStep, double targetRelativeError)
		{
			return default(Complex);
		}
	}
}
