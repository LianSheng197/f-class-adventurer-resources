using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class ConwayMaxwellPoisson : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__47 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double lambda;

			public double _003C_003E3__lambda;

			private double nu;

			public double _003C_003E3__nu;

			private double z;

			public double _003C_003E3__z;

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
			public _003CSamplesUnchecked_003Ed__47(int _003C_003E1__state)
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

		private readonly double _lambda;

		private readonly double _nu;

		private double _mean;

		private double _variance;

		private double _z;

		private const double Tolerance = 1E-12;

		public double Lambda => 0.0;

		public double Nu => 0.0;

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

		public int Mode => 0;

		public double Median => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		private double Z => 0.0;

		public ConwayMaxwellPoisson(double lambda, double nu)
		{
		}

		public ConwayMaxwellPoisson(double lambda, double nu, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double lambda, double nu)
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

		public static double PMF(double lambda, double nu, int k)
		{
			return 0.0;
		}

		public static double PMFLn(double lambda, double nu, int k)
		{
			return 0.0;
		}

		public static double CDF(double lambda, double nu, double x)
		{
			return 0.0;
		}

		private static double Normalization(double lambda, double nu)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, double lambda, double nu, double z)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, double lambda, double nu, double z)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__47))]
		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, double lambda, double nu, double z)
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

		public static int Sample(System.Random rnd, double lambda, double nu)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, double lambda, double nu)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, double lambda, double nu)
		{
		}

		public static int Sample(double lambda, double nu)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(double lambda, double nu)
		{
			return null;
		}

		public static void Samples(int[] values, double lambda, double nu)
		{
		}
	}
}
