using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class Bernoulli : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamples_003Ed__42 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Bernoulli _003C_003E4__this;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CSamples_003Ed__42(int _003C_003E1__state)
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
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
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

		private readonly double _p;

		public double P => 0.0;

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

		public double StdDev => 0.0;

		public double Variance => 0.0;

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		public int Mode => 0;

		public int[] Modes => null;

		public double Median => 0.0;

		public Bernoulli(double p)
		{
		}

		public Bernoulli(double p, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double p)
		{
			return false;
		}

		public double Probability(int k)
		{
			return 0.0;
		}

		public double ProbabilityLn(int k)
		{
			return 0.0;
		}

		public double CumulativeDistribution(double x)
		{
			return 0.0;
		}

		public static double PMF(double p, int k)
		{
			return 0.0;
		}

		public static double PMFLn(double p, int k)
		{
			return 0.0;
		}

		public static double CDF(double p, double x)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, double p)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, double p)
		{
		}

		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, double p)
		{
			return null;
		}

		public int Sample()
		{
			return 0;
		}

		public void Samples(int[] values)
		{
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__42))]
		public IEnumerable<int> Samples()
		{
			return null;
		}

		public static int Sample(System.Random rnd, double p)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, double p)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, double p)
		{
		}

		public static int Sample(double p)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(double p)
		{
			return null;
		}

		public static void Samples(int[] values, double p)
		{
		}
	}
}
