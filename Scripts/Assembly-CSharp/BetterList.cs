using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DebuggerHidden]
		[DebuggerStepThrough]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public T[] buffer;

	public int size;

	[Obsolete("Access the list.buffer[index] instead -- direct array access avoids a copy, so it can be much faster")]
	[DebuggerHidden]
	public T Item
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	private void AllocateMore()
	{
	}

	private void Trim()
	{
	}

	public void Clear()
	{
	}

	public void Release()
	{
	}

	public void Add(T item)
	{
	}

	public void Insert(int index, T item)
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public T Pop()
	{
		return default(T);
	}

	public T[] ToArray()
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public void Sort(CompareFunc comparer)
	{
	}
}
