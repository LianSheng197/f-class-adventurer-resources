using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class TruncatedPareto : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__43 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double scale;

			public double _003C_003E3__scale;

			private double shape;

			public double _003C_003E3__shape;

			private double truncation;

			public double _003C_003E3__truncation;

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
			public _003CSamplesUnchecked_003Ed__43(int _003C_003E1__state)
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

		public double Scale
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Shape
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Truncation
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double StdDev => 0.0;

		public double Mode => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public double Median => 0.0;

		public TruncatedPareto(double scale, double shape, double truncation, System.Random randomSource = null)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double scale, double shape, double truncation)
		{
			return false;
		}

		public double GetMoment(int n)
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

		public static double Sample(System.Random rnd, double scale, double shape, double truncation)
		{
			return 0.0;
		}

		public static void Samples(System.Random rnd, double[] values, double scale, double shape, double truncation)
		{
		}

		public static IEnumerable<double> Samples(System.Random rnd, double scale, double shape, double truncation)
		{
			return null;
		}

		internal static double SampleUnchecked(System.Random rnd, double scale, double shape, double truncation)
		{
			return 0.0;
		}

		internal static void SamplesUnchecked(System.Random rnd, double[] values, double scale, double shape, double truncation)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__43))]
		internal static IEnumerable<double> SamplesUnchecked(System.Random rnd, double scale, double shape, double truncation)
		{
			return null;
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

		public static double InvCDF(double scale, double shape, double truncation, double p)
		{
			return 0.0;
		}

		public static double PDF(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		public static double CDF(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		private static double DensityImpl(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		private static double DensityLnImpl(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		private static double CumulativeDistributionImpl(double scale, double shape, double truncation, double x)
		{
			return 0.0;
		}

		private static double InvCDFUncheckedImpl(double scale, double shape, double truncation, double p)
		{
			return 0.0;
		}
	}
}
