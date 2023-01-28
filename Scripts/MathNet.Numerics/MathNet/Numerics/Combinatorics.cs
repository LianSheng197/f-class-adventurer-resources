using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics
{
	public static class Combinatorics
	{
		[CompilerGenerated]
		private sealed class _003CSelectCombination_003Ed__10<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> data;

			public IEnumerable<T> _003C_003E3__data;

			private int elementsToChoose;

			public int _003C_003E3__elementsToChoose;

			private System.Random randomSource;

			public System.Random _003C_003E3__randomSource;

			private T[] _003Carray_003E5__2;

			private bool[] _003Cmask_003E5__3;

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
			public _003CSelectCombination_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CSelectCombinationWithRepetition_003Ed__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int elementsToChoose;

			public int _003C_003E3__elementsToChoose;

			private IEnumerable<T> data;

			public IEnumerable<T> _003C_003E3__data;

			private System.Random randomSource;

			public System.Random _003C_003E3__randomSource;

			private T[] _003Carray_003E5__2;

			private int[] _003Cmask_003E5__3;

			private int _003Ci_003E5__4;

			private int _003Cj_003E5__5;

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
			public _003CSelectCombinationWithRepetition_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CSelectPermutation_003Ed__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random randomSource;

			public System.Random _003C_003E3__randomSource;

			private IEnumerable<T> data;

			public IEnumerable<T> _003C_003E3__data;

			private System.Random _003Crandom_003E5__2;

			private T[] _003Carray_003E5__3;

			private int _003Ci_003E5__4;

			private int _003Ck_003E5__5;

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
			public _003CSelectPermutation_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CSelectVariation_003Ed__15<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random randomSource;

			public System.Random _003C_003E3__randomSource;

			private IEnumerable<T> data;

			public IEnumerable<T> _003C_003E3__data;

			private int elementsToChoose;

			public int _003C_003E3__elementsToChoose;

			private System.Random _003Crandom_003E5__2;

			private T[] _003Carray_003E5__3;

			private int _003Ci_003E5__4;

			private int _003CswapIndex_003E5__5;

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
			public _003CSelectVariation_003Ed__15(int _003C_003E1__state)
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
		private sealed class _003CSelectVariationWithRepetition_003Ed__17<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int elementsToChoose;

			public int _003C_003E3__elementsToChoose;

			private IEnumerable<T> data;

			public IEnumerable<T> _003C_003E3__data;

			private System.Random randomSource;

			public System.Random _003C_003E3__randomSource;

			private T[] _003Carray_003E5__2;

			private int[] _003Cindices_003E5__3;

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
			public _003CSelectVariationWithRepetition_003Ed__17(int _003C_003E1__state)
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

		public static double Variations(int n, int k)
		{
			return 0.0;
		}

		public static double VariationsWithRepetition(int n, int k)
		{
			return 0.0;
		}

		public static double Combinations(int n, int k)
		{
			return 0.0;
		}

		public static double CombinationsWithRepetition(int n, int k)
		{
			return 0.0;
		}

		public static double Permutations(int n)
		{
			return 0.0;
		}

		public static int[] GeneratePermutation(int n, System.Random randomSource = null)
		{
			return null;
		}

		public static void SelectPermutationInplace<T>(T[] data, System.Random randomSource = null)
		{
		}

		[IteratorStateMachine(typeof(_003CSelectPermutation_003Ed__7<>))]
		public static IEnumerable<T> SelectPermutation<T>(this IEnumerable<T> data, System.Random randomSource = null)
		{
			return null;
		}

		public static bool[] GenerateCombination(int n, System.Random randomSource = null)
		{
			return null;
		}

		public static bool[] GenerateCombination(int n, int k, System.Random randomSource = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectCombination_003Ed__10<>))]
		public static IEnumerable<T> SelectCombination<T>(this IEnumerable<T> data, int elementsToChoose, System.Random randomSource = null)
		{
			return null;
		}

		public static int[] GenerateCombinationWithRepetition(int n, int k, System.Random randomSource = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectCombinationWithRepetition_003Ed__12<>))]
		public static IEnumerable<T> SelectCombinationWithRepetition<T>(this IEnumerable<T> data, int elementsToChoose, System.Random randomSource = null)
		{
			return null;
		}

		public static int[] GenerateVariation(int n, int k, System.Random randomSource = null)
		{
			return null;
		}

		public static BigInteger[] GenerateVariation(BigInteger n, int k, System.Random randomSource = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectVariation_003Ed__15<>))]
		public static IEnumerable<T> SelectVariation<T>(this IEnumerable<T> data, int elementsToChoose, System.Random randomSource = null)
		{
			return null;
		}

		public static int[] GenerateVariationWithRepetition(int n, int k, System.Random randomSource = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectVariationWithRepetition_003Ed__17<>))]
		public static IEnumerable<T> SelectVariationWithRepetition<T>(this IEnumerable<T> data, int elementsToChoose, System.Random randomSource = null)
		{
			return null;
		}
	}
}
