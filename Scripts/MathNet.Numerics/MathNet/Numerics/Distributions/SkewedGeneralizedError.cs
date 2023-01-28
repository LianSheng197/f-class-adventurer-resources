using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class SkewedGeneralizedError : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__56 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double location;

			public double _003C_003E3__location;

			private double scale;

			public double _003C_003E3__scale;

			private double skew;

			public double _003C_003E3__skew;

			private double p;

			public double _003C_003E3__p;

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
			public _003CSamplesUnchecked_003Ed__56(int _003C_003E1__state)
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

		private readonly double _skewness;

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

		public double Location
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
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

		public double Skew
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double P
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public double Mode => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double StdDev => 0.0;

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public double Median => 0.0;

		public SkewedGeneralizedError()
		{
		}

		public SkewedGeneralizedError(double location, double scale, double skew, double p)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double location, double scale, double skew, double p)
		{
			return false;
		}

		private double CalculateSkewness()
		{
			return 0.0;
		}

		private static double AdjustScale(double scale, double skew, double p)
		{
			return 0.0;
		}

		private static double AdjustX(double x, double scale, double skew, double p)
		{
			return 0.0;
		}

		private static double AdjustAddend(double scale, double skew, double p)
		{
			return 0.0;
		}

		public static double PDF(double location, double scale, double skew, double p, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double location, double scale, double skew, double p, double x)
		{
			return 0.0;
		}

		public static double CDF(double location, double scale, double skew, double p, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double location, double scale, double skew, double p, double pr)
		{
			return 0.0;
		}

		public double InverseCumulativeDistribution(double p)
		{
			return 0.0;
		}

		public double CumulativeDistribution(double x)
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

		private static double SampleUnchecked(System.Random rnd, double location, double scale, double skew, double p)
		{
			return 0.0;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double location, double scale, double skew, double p)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__56))]
		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double location, double scale, double skew, double p)
		{
			return null;
		}

		public static double Sample(System.Random rnd, double location, double scale, double skew, double p)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double location, double scale, double skew, double p)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double location, double scale, double skew, double p)
		{
		}

		public static double Sample(double location, double scale, double skew, double p)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double location, double scale, double skew, double p)
		{
			return null;
		}

		public static void Samples(double[] values, double location, double scale, double skew, double p)
		{
		}
	}
}
