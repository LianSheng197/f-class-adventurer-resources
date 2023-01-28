using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class Normal : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__44 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double mean;

			public double _003C_003E3__mean;

			private double stddev;

			public double _003C_003E3__stddev;

			private double _003Cy_003E5__2;

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
			public _003CSamplesUnchecked_003Ed__44(int _003C_003E1__state)
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

		private readonly double _mean;

		private readonly double _stdDev;

		public double Mean => 0.0;

		public double StdDev => 0.0;

		public double Variance => 0.0;

		public double Precision => 0.0;

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

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public double Mode => 0.0;

		public double Median => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public Normal()
		{
		}

		public Normal(System.Random randomSource)
		{
		}

		public Normal(double mean, double stddev)
		{
		}

		public Normal(double mean, double stddev, System.Random randomSource)
		{
		}

		public static Normal WithMeanStdDev(double mean, double stddev, System.Random randomSource = null)
		{
			return null;
		}

		public static Normal WithMeanVariance(double mean, double var, System.Random randomSource = null)
		{
			return null;
		}

		public static Normal WithMeanPrecision(double mean, double precision, System.Random randomSource = null)
		{
			return null;
		}

		public static Normal Estimate(IEnumerable<double> samples, System.Random randomSource = null)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double mean, double stddev)
		{
			return false;
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

		public double InverseCumulativeDistribution(double p)
		{
			return 0.0;
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

		internal static double SampleUnchecked(System.Random rnd, double mean, double stddev)
		{
			return 0.0;
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__44))]
		internal static IEnumerable<double> SamplesUnchecked(System.Random rnd, double mean, double stddev)
		{
			return null;
		}

		internal static void SamplesUnchecked(System.Random rnd, double[] values, double mean, double stddev)
		{
		}

		private static bool PolarTransform(double a, double b, out double x, out double y)
		{
			x = default(double);
			y = default(double);
			return false;
		}

		public static double PDF(double mean, double stddev, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double mean, double stddev, double x)
		{
			return 0.0;
		}

		public static double CDF(double mean, double stddev, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double mean, double stddev, double p)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double mean, double stddev)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double mean, double stddev)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double mean, double stddev)
		{
		}

		public static double Sample(double mean, double stddev)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double mean, double stddev)
		{
			return null;
		}

		public static void Samples(double[] values, double mean, double stddev)
		{
		}
	}
}
