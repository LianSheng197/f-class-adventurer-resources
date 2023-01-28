using System;
using MathNet.Numerics.Distributions;

namespace MathNet.Numerics.Statistics.Mcmc
{
	public class UnivariateHybridMC : HybridMCGeneric<double>
	{
		private readonly Normal _distribution;

		private double _sdv;

		public double MomentumStdDev
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public UnivariateHybridMC(double x0, DensityLn<double> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval = 0, double pSdv = 1.0)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		public UnivariateHybridMC(double x0, DensityLn<double> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, double pSdv, System.Random randomSource)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		public UnivariateHybridMC(double x0, DensityLn<double> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, double pSdv, System.Random randomSource, DiffMethod diff)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		protected override double Copy(double source)
		{
			return 0.0;
		}

		protected override double Create()
		{
			return 0.0;
		}

		protected override void DoAdd(ref double first, double factor, double second)
		{
		}

		protected override double DoProduct(double first, double second)
		{
			return 0.0;
		}

		protected override void DoSubtract(ref double first, double factor, double second)
		{
		}

		protected override void RandomizeMomentum(ref double p)
		{
		}

		private static double Grad(DensityLn<double> function, double x)
		{
			return 0.0;
		}
	}
}
