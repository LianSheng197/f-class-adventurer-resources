using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class Hypergeometric : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__43 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private int population;

			public int _003C_003E3__population;

			private int success;

			public int _003C_003E3__success;

			private int draws;

			public int _003C_003E3__draws;

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

		private readonly int _population;

		private readonly int _success;

		private readonly int _draws;

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

		public int Population => 0;

		public int Draws => 0;

		public int Success => 0;

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double StdDev => 0.0;

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public int Mode => 0;

		public double Median => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		public Hypergeometric(int population, int success, int draws)
		{
		}

		public Hypergeometric(int population, int success, int draws, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(int population, int success, int draws)
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

		public static double PMF(int population, int success, int draws, int k)
		{
			return 0.0;
		}

		public static double PMFLn(int population, int success, int draws, int k)
		{
			return 0.0;
		}

		public static double CDF(int population, int success, int draws, double x)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, int population, int success, int draws)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, int population, int success, int draws)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__43))]
		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, int population, int success, int draws)
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

		public IEnumerable<int> Samples()
		{
			return null;
		}

		public static int Sample(System.Random rnd, int population, int success, int draws)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, int population, int success, int draws)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, int population, int success, int draws)
		{
		}

		public static int Sample(int population, int success, int draws)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(int population, int success, int draws)
		{
			return null;
		}

		public static void Samples(int[] values, int population, int success, int draws)
		{
		}
	}
}
