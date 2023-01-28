using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class NormalGamma : IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamples_003Ed__31 : IEnumerable<MeanPrecisionPair>, IEnumerable, IEnumerator<MeanPrecisionPair>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MeanPrecisionPair _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public NormalGamma _003C_003E4__this;

			private MeanPrecisionPair System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002EDistributions_002EMeanPrecisionPair_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(MeanPrecisionPair);
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
			public _003CSamples_003Ed__31(int _003C_003E1__state)
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
			private IEnumerator<MeanPrecisionPair> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002EDistributions_002EMeanPrecisionPair_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSamples_003Ed__33 : IEnumerable<MeanPrecisionPair>, IEnumerable, IEnumerator<MeanPrecisionPair>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MeanPrecisionPair _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private double meanLocation;

			public double _003C_003E3__meanLocation;

			private double meanScale;

			public double _003C_003E3__meanScale;

			private double precisionShape;

			public double _003C_003E3__precisionShape;

			private double precisionInvScale;

			public double _003C_003E3__precisionInvScale;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private MeanPrecisionPair System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002EDistributions_002EMeanPrecisionPair_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(MeanPrecisionPair);
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
			public _003CSamples_003Ed__33(int _003C_003E1__state)
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
			private IEnumerator<MeanPrecisionPair> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002EDistributions_002EMeanPrecisionPair_003E_002EGetEnumerator()
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

		private readonly double _meanLocation;

		private readonly double _meanScale;

		private readonly double _precisionShape;

		private readonly double _precisionInvScale;

		public double MeanLocation => 0.0;

		public double MeanScale => 0.0;

		public double PrecisionShape => 0.0;

		public double PrecisionInverseScale => 0.0;

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

		public MeanPrecisionPair Mean => default(MeanPrecisionPair);

		public MeanPrecisionPair Variance => default(MeanPrecisionPair);

		public NormalGamma(double meanLocation, double meanScale, double precisionShape, double precisionInverseScale)
		{
		}

		public NormalGamma(double meanLocation, double meanScale, double precisionShape, double precisionInverseScale, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double meanLocation, double meanScale, double precShape, double precInvScale)
		{
			return false;
		}

		public StudentT MeanMarginal()
		{
			return null;
		}

		public Gamma PrecisionMarginal()
		{
			return null;
		}

		public double Density(MeanPrecisionPair mp)
		{
			return 0.0;
		}

		public double Density(double mean, double prec)
		{
			return 0.0;
		}

		public double DensityLn(MeanPrecisionPair mp)
		{
			return 0.0;
		}

		public double DensityLn(double mean, double prec)
		{
			return 0.0;
		}

		public MeanPrecisionPair Sample()
		{
			return default(MeanPrecisionPair);
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__31))]
		public IEnumerable<MeanPrecisionPair> Samples()
		{
			return null;
		}

		public static MeanPrecisionPair Sample(System.Random rnd, double meanLocation, double meanScale, double precisionShape, double precisionInverseScale)
		{
			return default(MeanPrecisionPair);
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__33))]
		public static IEnumerable<MeanPrecisionPair> Samples(System.Random rnd, double meanLocation, double meanScale, double precisionShape, double precisionInvScale)
		{
			return null;
		}
	}
}
