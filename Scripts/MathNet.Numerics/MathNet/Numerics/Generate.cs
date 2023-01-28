using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;

namespace MathNet.Numerics
{
	public static class Generate
	{
		[CompilerGenerated]
		private sealed class _003CFibonacciSequence_003Ed__39 : IEnumerable<BigInteger>, IEnumerable, IEnumerator<BigInteger>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BigInteger _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private BigInteger _003Ca_003E5__2;

			private BigInteger _003Cb_003E5__3;

			private BigInteger System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ENumerics_002EBigInteger_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(BigInteger);
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
			public _003CFibonacciSequence_003Ed__39(int _003C_003E1__state)
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
			private IEnumerator<BigInteger> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ENumerics_002EBigInteger_003E_002EGetEnumerator()
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
		private sealed class _003CImpulseSequence_003Ed__31 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int delay;

			public int _003C_003E3__delay;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private int _003Ci_003E5__2;

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
			public _003CImpulseSequence_003Ed__31(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPeriodicImpulseSequence_003Ed__33 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int delay;

			public int _003C_003E3__delay;

			private int period;

			public int _003C_003E3__period;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private int _003Ci_003E5__2;

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
			public _003CPeriodicImpulseSequence_003Ed__33(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPeriodicMapSequence_003Ed__17<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private double frequency;

			public double _003C_003E3__frequency;

			private double samplingRate;

			public double _003C_003E3__samplingRate;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private double phase;

			public double _003C_003E3__phase;

			private int delay;

			public int _003C_003E3__delay;

			private Func<double, T> map;

			public Func<double, T> _003C_003E3__map;

			private double _003Cstep_003E5__2;

			private int _003Ck_003E5__3;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CPeriodicMapSequence_003Ed__17(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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
		private sealed class _003CPeriodicSequence_003Ed__16 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private double frequency;

			public double _003C_003E3__frequency;

			private double samplingRate;

			public double _003C_003E3__samplingRate;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private double phase;

			public double _003C_003E3__phase;

			private int delay;

			public int _003C_003E3__delay;

			private double _003Cstep_003E5__2;

			private int _003Ck_003E5__3;

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
			public _003CPeriodicSequence_003Ed__16(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRepeatSequence_003Ed__27<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private T value;

			public T _003C_003E3__value;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CRepeatSequence_003Ed__27(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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
		private sealed class _003CSinusoidalSequence_003Ed__19 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private double frequency;

			public double _003C_003E3__frequency;

			private double samplingRate;

			public double _003C_003E3__samplingRate;

			private double phase;

			public double _003C_003E3__phase;

			private int delay;

			public int _003C_003E3__delay;

			private double mean;

			public double _003C_003E3__mean;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private double _003Cstep_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CSinusoidalSequence_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStepSequence_003Ed__29 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int delay;

			public int _003C_003E3__delay;

			private double amplitude;

			public double _003C_003E3__amplitude;

			private int _003Ci_003E5__2;

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
			public _003CStepSequence_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CUnfoldSequence_003Ed__36<T, TState> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Func<TState, Tuple<T, TState>> f;

			public Func<TState, Tuple<T, TState>> _003C_003E3__f;

			private TState state;

			public TState _003C_003E3__state;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CUnfoldSequence_003Ed__36(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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
		private sealed class _003CUnfoldSequence_003Ed__37<T, TState> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Func<TState, (T, TState)> f;

			public Func<TState, (T, TState)> _003C_003E3__f;

			private TState state;

			public TState _003C_003E3__state;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CUnfoldSequence_003Ed__37(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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
		private sealed class _003CUniformMap2Sequence_003Ed__45<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Func<double, double, T> map;

			public Func<double, double, T> _003C_003E3__map;

			private SystemRandomSource _003Crnd1_003E5__2;

			private System.Random _003Crnd2_003E5__3;

			private int _003Ci_003E5__4;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CUniformMap2Sequence_003Ed__45(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public static T[] Map<TA, T>(TA[] points, Func<TA, T> map)
		{
			return null;
		}

		public static IEnumerable<T> MapSequence<TA, T>(IEnumerable<TA> points, Func<TA, T> map)
		{
			return null;
		}

		public static T[] Map2<TA, TB, T>(TA[] pointsA, TB[] pointsB, Func<TA, TB, T> map)
		{
			return null;
		}

		public static IEnumerable<T> Map2Sequence<TA, TB, T>(IEnumerable<TA> pointsA, IEnumerable<TB> pointsB, Func<TA, TB, T> map)
		{
			return null;
		}

		public static double[] LinearSpaced(int length, double start, double stop)
		{
			return null;
		}

		public static T[] LinearSpacedMap<T>(int length, double start, double stop, Func<double, T> map)
		{
			return null;
		}

		public static double[] LogSpaced(int length, double startExponent, double stopExponent)
		{
			return null;
		}

		public static T[] LogSpacedMap<T>(int length, double startExponent, double stopExponent, Func<double, T> map)
		{
			return null;
		}

		public static double[] LinearRange(int start, int stop)
		{
			return null;
		}

		public static int[] LinearRangeInt32(int start, int stop)
		{
			return null;
		}

		public static double[] LinearRange(int start, int step, int stop)
		{
			return null;
		}

		public static int[] LinearRangeInt32(int start, int step, int stop)
		{
			return null;
		}

		public static double[] LinearRange(double start, double step, double stop)
		{
			return null;
		}

		public static T[] LinearRangeMap<T>(double start, double step, double stop, Func<double, T> map)
		{
			return null;
		}

		public static double[] Periodic(int length, double samplingRate, double frequency, double amplitude = 1.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		public static T[] PeriodicMap<T>(int length, Func<double, T> map, double samplingRate, double frequency, double amplitude = 1.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPeriodicSequence_003Ed__16))]
		public static IEnumerable<double> PeriodicSequence(double samplingRate, double frequency, double amplitude = 1.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPeriodicMapSequence_003Ed__17<>))]
		public static IEnumerable<T> PeriodicMapSequence<T>(Func<double, T> map, double samplingRate, double frequency, double amplitude = 1.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		public static double[] Sinusoidal(int length, double samplingRate, double frequency, double amplitude, double mean = 0.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSinusoidalSequence_003Ed__19))]
		public static IEnumerable<double> SinusoidalSequence(double samplingRate, double frequency, double amplitude, double mean = 0.0, double phase = 0.0, int delay = 0)
		{
			return null;
		}

		public static double[] Square(int length, int highDuration, int lowDuration, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static IEnumerable<double> SquareSequence(int highDuration, int lowDuration, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static double[] Triangle(int length, int raiseDuration, int fallDuration, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static IEnumerable<double> TriangleSequence(int raiseDuration, int fallDuration, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static double[] Sawtooth(int length, int period, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static IEnumerable<double> SawtoothSequence(int period, double lowValue, double highValue, int delay = 0)
		{
			return null;
		}

		public static T[] Repeat<T>(int length, T value)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRepeatSequence_003Ed__27<>))]
		public static IEnumerable<T> RepeatSequence<T>(T value)
		{
			return null;
		}

		public static double[] Step(int length, double amplitude, int delay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStepSequence_003Ed__29))]
		public static IEnumerable<double> StepSequence(double amplitude, int delay)
		{
			return null;
		}

		public static double[] Impulse(int length, double amplitude, int delay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CImpulseSequence_003Ed__31))]
		public static IEnumerable<double> ImpulseSequence(double amplitude, int delay)
		{
			return null;
		}

		public static double[] PeriodicImpulse(int length, int period, double amplitude, int delay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPeriodicImpulseSequence_003Ed__33))]
		public static IEnumerable<double> PeriodicImpulseSequence(int period, double amplitude, int delay)
		{
			return null;
		}

		public static T[] Unfold<T, TState>(int length, Func<TState, Tuple<T, TState>> f, TState state)
		{
			return null;
		}

		public static T[] Unfold<T, TState>(int length, Func<TState, (T, TState)> f, TState state)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUnfoldSequence_003Ed__36<, >))]
		public static IEnumerable<T> UnfoldSequence<T, TState>(Func<TState, Tuple<T, TState>> f, TState state)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUnfoldSequence_003Ed__37<, >))]
		public static IEnumerable<T> UnfoldSequence<T, TState>(Func<TState, (T, TState)> f, TState state)
		{
			return null;
		}

		public static BigInteger[] Fibonacci(int length)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFibonacciSequence_003Ed__39))]
		public static IEnumerable<BigInteger> FibonacciSequence()
		{
			return null;
		}

		public static double[] Uniform(int length)
		{
			return null;
		}

		public static IEnumerable<double> UniformSequence()
		{
			return null;
		}

		public static T[] UniformMap<T>(int length, Func<double, T> map)
		{
			return null;
		}

		public static IEnumerable<T> UniformMapSequence<T>(Func<double, T> map)
		{
			return null;
		}

		public static T[] UniformMap2<T>(int length, Func<double, double, T> map)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUniformMap2Sequence_003Ed__45<>))]
		public static IEnumerable<T> UniformMap2Sequence<T>(Func<double, double, T> map)
		{
			return null;
		}

		public static double[] Standard(int length)
		{
			return null;
		}

		public static IEnumerable<double> StandardSequence()
		{
			return null;
		}

		public static double[] Normal(int length, double mean, double standardDeviation)
		{
			return null;
		}

		public static IEnumerable<double> NormalSequence(double mean, double standardDeviation)
		{
			return null;
		}

		public static double[] Random(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static IEnumerable<double> Random(IContinuousDistribution distribution)
		{
			return null;
		}

		public static float[] RandomSingle(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static IEnumerable<float> RandomSingle(IContinuousDistribution distribution)
		{
			return null;
		}

		public static Complex[] RandomComplex(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static IEnumerable<Complex> RandomComplex(IContinuousDistribution distribution)
		{
			return null;
		}

		public static Complex32[] RandomComplex32(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static IEnumerable<Complex32> RandomComplex32(IContinuousDistribution distribution)
		{
			return null;
		}

		public static T[] RandomMap<T>(int length, IContinuousDistribution distribution, Func<double, T> map)
		{
			return null;
		}

		public static IEnumerable<T> RandomMapSequence<T>(IContinuousDistribution distribution, Func<double, T> map)
		{
			return null;
		}

		public static T[] RandomMap2<T>(int length, IContinuousDistribution distribution, Func<double, double, T> map)
		{
			return null;
		}

		public static IEnumerable<T> RandomMap2Sequence<T>(IContinuousDistribution distribution, Func<double, double, T> map)
		{
			return null;
		}
	}
}
