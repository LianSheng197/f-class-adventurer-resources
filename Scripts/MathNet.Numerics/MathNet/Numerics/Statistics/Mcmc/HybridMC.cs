using System;
using MathNet.Numerics.Distributions;

namespace MathNet.Numerics.Statistics.Mcmc
{
	public class HybridMC : HybridMCGeneric<double[]>
	{
		private readonly int _length;

		private Normal _pDistribution;

		private double[] _mpSdv;

		public double[] MomentumStdDev
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HybridMC(double[] x0, DensityLn<double[]> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval = 0)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		public HybridMC(double[] x0, DensityLn<double[]> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, double[] pSdv)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		public HybridMC(double[] x0, DensityLn<double[]> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, double[] pSdv, System.Random randomSource)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		public HybridMC(double[] x0, DensityLn<double[]> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, double[] pSdv, System.Random randomSource, DiffMethod diff)
		{
			((HybridMCGeneric<>)(object)this)._002Ector((T)default(_00210), (DensityLn<T>)null, 0, 0.0, 0, (System.Random)null, (HybridMCGeneric<T>.DiffMethod)null);
		}

		private void Initialize(double[] x0)
		{
		}

		private void CheckVariance(double[] pSdv)
		{
		}

		protected override double[] Copy(double[] source)
		{
			return null;
		}

		protected override double[] Create()
		{
			return null;
		}

		protected override void DoAdd(ref double[] first, double factor, double[] second)
		{
		}

		protected override void DoSubtract(ref double[] first, double factor, double[] second)
		{
		}

		protected override double DoProduct(double[] first, double[] second)
		{
			return 0.0;
		}

		protected override void RandomizeMomentum(ref double[] p)
		{
		}

		private static double[] Grad(DensityLn<double[]> function, double[] x)
		{
			return null;
		}
	}
}
