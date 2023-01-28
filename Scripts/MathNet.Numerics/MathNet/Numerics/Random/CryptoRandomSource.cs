using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MathNet.Numerics.Random
{
	public sealed class CryptoRandomSource : RandomSource, IDisposable
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__12 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private RandomNumberGenerator _003Crnd_003E5__2;

			private byte[] _003Cbuffer_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CDoubleSequence_003Ed__12(int _003C_003E1__state)
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

		private const double Reciprocal = 2.3283064365386963E-10;

		private readonly RandomNumberGenerator _crypto;

		public CryptoRandomSource()
		{
		}

		public CryptoRandomSource(RandomNumberGenerator rng)
		{
		}

		public CryptoRandomSource(bool threadSafe)
		{
		}

		public CryptoRandomSource(RandomNumberGenerator rng, bool threadSafe)
		{
		}

		protected override void DoSampleBytes(byte[] buffer)
		{
		}

		protected override double DoSample()
		{
			return 0.0;
		}

		protected override int DoSampleInteger()
		{
			return 0;
		}

		public void Dispose()
		{
		}

		public static void Doubles(double[] values)
		{
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__12))]
		public static IEnumerable<double> DoubleSequence()
		{
			return null;
		}
	}
}
