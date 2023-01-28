using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class Erlang : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamples_003Ed__41 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Erlang _003C_003E4__this;

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
			public _003CSamples_003Ed__41(int _003C_003E1__state)
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

		private readonly int _shape;

		private readonly double _rate;

		public int Shape => 0;

		public double Rate => 0.0;

		public double Scale => 0.0;

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

		public Erlang(int shape, double rate)
		{
		}

		public Erlang(int shape, double rate, System.Random randomSource)
		{
		}

		public static Erlang WithShapeScale(int shape, double scale, System.Random randomSource = null)
		{
			return null;
		}

		public static Erlang WithShapeRate(int shape, double rate, System.Random randomSource = null)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(int shape, double rate)
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

		public double Sample()
		{
			return 0.0;
		}

		public void Samples(double[] values)
		{
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__41))]
		public IEnumerable<double> Samples()
		{
			return null;
		}

		public static double PDF(int shape, double rate, double x)
		{
			return 0.0;
		}

		public static double PDFLn(int shape, double rate, double x)
		{
			return 0.0;
		}

		public static double CDF(int shape, double rate, double x)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, int shape, double rate)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, int shape, double rate)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, int shape, double rate)
		{
		}

		public static double Sample(int shape, double rate)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(int shape, double rate)
		{
			return null;
		}

		public static void Samples(double[] values, int shape, double rate)
		{
		}
	}
}
