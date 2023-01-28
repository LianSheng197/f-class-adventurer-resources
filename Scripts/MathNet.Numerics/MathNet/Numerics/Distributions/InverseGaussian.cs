using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class InverseGaussian : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__41 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double mu;

			public double _003C_003E3__mu;

			private double lambda;

			public double _003C_003E3__lambda;

			private double System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EDouble_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0.0;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSamplesUnchecked_003Ed__41(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<double> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EDouble_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private System.Random _random;

		public double Mu
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Lambda
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public System.Random RandomSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double StdDev => 0.0;

		public double Median => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public double Skewness => 0.0;

		public double Kurtosis => 0.0;

		public double Mode => 0.0;

		public double Entropy => 0.0;

		public InverseGaussian(double mu, double lambda, System.Random randomSource = null)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double mu, double lambda)
		{
			return false;
		}

		public double Sample()
		{
			return 0.0;
		}

		public void Samples(double[] values)
		{
		}

		public IEnumerable<double> Samples()
		{
			return null;
		}

		public static double Sample(System.Random rnd, double mu, double lambda)
		{
			return 0.0;
		}

		public static void Samples(System.Random rnd, double[] values, double mu, double lambda)
		{
		}

		public static IEnumerable<double> Samples(System.Random rnd, double mu, double lambda)
		{
			return null;
		}

		private static double SampleUnchecked(System.Random rnd, double mu, double lambda)
		{
			return 0.0;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double mu, double lambda)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__41))]
		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double mu, double lambda)
		{
			return null;
		}

		private static double InverseGaussianSampleImpl(double mu, double lambda, double normalSample, double uniformSample)
		{
			return 0.0;
		}

		public double Density(double x)
		{
			return 0.0;
		}

		public double DensityLn(double x)
		{
			return 0.0;
		}

		public double CumulativeDistribution(double x)
		{
			return 0.0;
		}

		public double InvCDF(double p)
		{
			return 0.0;
		}

		public static double PDF(double mu, double lambda, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double mu, double lambda, double x)
		{
			return 0.0;
		}

		public static double CDF(double mu, double lambda, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double mu, double lambda, double p)
		{
			return 0.0;
		}

		public static InverseGaussian Estimate(IEnumerable<double> samples, System.Random randomSource = null)
		{
			return null;
		}

		private static double DensityImpl(double mu, double lambda, double x)
		{
			return 0.0;
		}

		private static double DensityLnImpl(double mu, double lambda, double x)
		{
			return 0.0;
		}

		private static double CumulativeDistributionImpl(double mu, double lambda, double x)
		{
			return 0.0;
		}
	}
}
