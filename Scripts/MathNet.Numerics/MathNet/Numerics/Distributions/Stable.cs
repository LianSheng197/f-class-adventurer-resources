using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class Stable : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__43 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double alpha;

			public double _003C_003E3__alpha;

			private double beta;

			public double _003C_003E3__beta;

			private double scale;

			public double _003C_003E3__scale;

			private double location;

			public double _003C_003E3__location;

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

		private readonly double _alpha;

		private readonly double _beta;

		private readonly double _scale;

		private readonly double _location;

		public double Alpha => 0.0;

		public double Beta => 0.0;

		public double Scale => 0.0;

		public double Location => 0.0;

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

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public double Mode => 0.0;

		public double Median => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public Stable(double alpha, double beta, double scale, double location)
		{
		}

		public Stable(double alpha, double beta, double scale, double location, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double alpha, double beta, double scale, double location)
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

		private static double SampleUnchecked(System.Random rnd, double alpha, double beta, double scale, double location)
		{
			return 0.0;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double alpha, double beta, double scale, double location)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__43))]
		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double alpha, double beta, double scale, double location)
		{
			return null;
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

		public static double PDF(double alpha, double beta, double scale, double location, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double alpha, double beta, double scale, double location, double x)
		{
			return 0.0;
		}

		public static double CDF(double alpha, double beta, double scale, double location, double x)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double alpha, double beta, double scale, double location)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double alpha, double beta, double scale, double location)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double alpha, double beta, double scale, double location)
		{
		}

		public static double Sample(double alpha, double beta, double scale, double location)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double alpha, double beta, double scale, double location)
		{
			return null;
		}

		public static void Samples(double[] values, double alpha, double beta, double scale, double location)
		{
		}
	}
}
