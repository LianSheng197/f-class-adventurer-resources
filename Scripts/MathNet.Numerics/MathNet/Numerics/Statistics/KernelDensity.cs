using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Statistics
{
	public static class KernelDensity
	{
		public static double Estimate(double x, double bandwidth, IList<double> samples, Func<double, double> kernel)
		{
			return 0.0;
		}

		public static double EstimateGaussian(double x, double bandwidth, IList<double> samples)
		{
			return 0.0;
		}

		public static double EstimateEpanechnikov(double x, double bandwidth, IList<double> samples)
		{
			return 0.0;
		}

		public static double EstimateUniform(double x, double bandwidth, IList<double> samples)
		{
			return 0.0;
		}

		public static double EstimateTriangular(double x, double bandwidth, IList<double> samples)
		{
			return 0.0;
		}

		public static double GaussianKernel(double x)
		{
			return 0.0;
		}

		public static double EpanechnikovKernel(double x)
		{
			return 0.0;
		}

		public static double UniformKernel(double x)
		{
			return 0.0;
		}

		public static double TriangularKernel(double x)
		{
			return 0.0;
		}
	}
}
