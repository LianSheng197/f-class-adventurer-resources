using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Linq
{
	public static class GameObjectExtensions
	{
		public struct ChildrenEnumerable : IEnumerable<GameObject>, IEnumerable
		{
			public struct Enumerator : IEnumerator<GameObject>, IEnumerator, IDisposable
			{
				private readonly int childCount;

				private readonly Transform originTransform;

				private readonly bool canRun;

				private bool withSelf;

				private int currentIndex;

				private GameObject current;

				public GameObject Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(Transform originTransform, bool withSelf, bool canRun)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			public struct OfComponentEnumerable<T> : IEnumerable<T>, IEnumerable where T : Component
			{
				private ChildrenEnumerable parent;

				public OfComponentEnumerable(ref ChildrenEnumerable parent)
				{
				}

				public OfComponentEnumerator<T> GetEnumerator()
				{
					return default(OfComponentEnumerator<T>);
				}

				private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
				{
					return null;
				}

				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}

				public void ForEach(Action<T> action)
				{
				}

				public T First()
				{
					return null;
				}

				public T FirstOrDefault()
				{
					return null;
				}

				public T[] ToArray()
				{
					return null;
				}

				public int ToArrayNonAlloc(ref T[] array)
				{
					return 0;
				}
			}

			public struct OfComponentEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : Component
			{
				private Enumerator enumerator;

				private T current;

				public T Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				public OfComponentEnumerator(ref ChildrenEnumerable parent)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			private readonly GameObject origin;

			private readonly bool withSelf;

			public ChildrenEnumerable(GameObject origin, bool withSelf)
			{
			}

			public OfComponentEnumerable<T> OfComponent<T>() where T : Component
			{
				return default(OfComponentEnumerable<T>);
			}

			public void Destroy(bool useDestroyImmediate = false, bool detachParent = false)
			{
			}

			public void Destroy(Func<GameObject, bool> predicate, bool useDestroyImmediate = false)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			private int GetChildrenSize()
			{
				return 0;
			}

			public void ForEach(Action<GameObject> action)
			{
			}

			public int ToArrayNonAlloc(ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc(Func<GameObject, bool> filter, ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector, ref T[] array)
			{
				return 0;
			}

			public GameObject[] ToArray()
			{
				return null;
			}

			public GameObject[] ToArray(Func<GameObject, bool> filter)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector)
			{
				return null;
			}

			public GameObject First()
			{
				return null;
			}

			public GameObject FirstOrDefault()
			{
				return null;
			}
		}

		public struct AncestorsEnumerable : IEnumerable<GameObject>, IEnumerable
		{
			public struct Enumerator : IEnumerator<GameObject>, IEnumerator, IDisposable
			{
				private readonly bool canRun;

				private GameObject current;

				private Transform currentTransform;

				private bool withSelf;

				public GameObject Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(GameObject origin, Transform originTransform, bool withSelf, bool canRun)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			public struct OfComponentEnumerable<T> : IEnumerable<T>, IEnumerable where T : Component
			{
				private AncestorsEnumerable parent;

				public OfComponentEnumerable(ref AncestorsEnumerable parent)
				{
				}

				public OfComponentEnumerator<T> GetEnumerator()
				{
					return default(OfComponentEnumerator<T>);
				}

				private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
				{
					return null;
				}

				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}

				public void ForEach(Action<T> action)
				{
				}

				public T First()
				{
					return null;
				}

				public T FirstOrDefault()
				{
					return null;
				}

				public T[] ToArray()
				{
					return null;
				}

				public int ToArrayNonAlloc(ref T[] array)
				{
					return 0;
				}
			}

			public struct OfComponentEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : Component
			{
				private Enumerator enumerator;

				private T current;

				public T Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				public OfComponentEnumerator(ref AncestorsEnumerable parent)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			private readonly GameObject origin;

			private readonly bool withSelf;

			public AncestorsEnumerable(GameObject origin, bool withSelf)
			{
			}

			public OfComponentEnumerable<T> OfComponent<T>() where T : Component
			{
				return default(OfComponentEnumerable<T>);
			}

			public void Destroy(bool useDestroyImmediate = false)
			{
			}

			public void Destroy(Func<GameObject, bool> predicate, bool useDestroyImmediate = false)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public void ForEach(Action<GameObject> action)
			{
			}

			public int ToArrayNonAlloc(ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc(Func<GameObject, bool> filter, ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector, ref T[] array)
			{
				return 0;
			}

			public GameObject[] ToArray()
			{
				return null;
			}

			public GameObject[] ToArray(Func<GameObject, bool> filter)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector)
			{
				return null;
			}

			public GameObject First()
			{
				return null;
			}

			public GameObject FirstOrDefault()
			{
				return null;
			}
		}

		public struct DescendantsEnumerable : IEnumerable<GameObject>, IEnumerable
		{
			internal class InternalUnsafeRefStack
			{
				public static Queue<InternalUnsafeRefStack> RefStackPool;

				public int size;

				public Enumerator[] array;

				public InternalUnsafeRefStack(int initialStackDepth)
				{
				}

				public void Push(ref Enumerator e)
				{
				}

				public void Reset()
				{
				}
			}

			public struct Enumerator : IEnumerator<GameObject>, IEnumerator, IDisposable
			{
				private readonly int childCount;

				private readonly Transform originTransform;

				private bool canRun;

				private bool withSelf;

				private int currentIndex;

				private GameObject current;

				private InternalUnsafeRefStack sharedStack;

				private Func<Transform, bool> descendIntoChildren;

				public GameObject Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(Transform originTransform, bool withSelf, bool canRun, InternalUnsafeRefStack sharedStack, Func<Transform, bool> descendIntoChildren)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				private bool MoveNextCore(bool peek, out GameObject current)
				{
					current = null;
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			public struct OfComponentEnumerable<T> : IEnumerable<T>, IEnumerable where T : Component
			{
				private DescendantsEnumerable parent;

				public OfComponentEnumerable(ref DescendantsEnumerable parent)
				{
				}

				public OfComponentEnumerator<T> GetEnumerator()
				{
					return default(OfComponentEnumerator<T>);
				}

				private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
				{
					return null;
				}

				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}

				public T First()
				{
					return null;
				}

				public T FirstOrDefault()
				{
					return null;
				}

				public void ForEach(Action<T> action)
				{
				}

				public T[] ToArray()
				{
					return null;
				}

				private void OfComponentDescendantsCore(ref Transform transform, ref Action<T> action)
				{
				}

				private void OfComponentDescendantsCore(ref Transform transform, ref int index, ref T[] array)
				{
				}

				public int ToArrayNonAlloc(ref T[] array)
				{
					return 0;
				}
			}

			public struct OfComponentEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : Component
			{
				private Enumerator enumerator;

				private T current;

				public T Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				public OfComponentEnumerator(ref DescendantsEnumerable parent)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			private static readonly Func<Transform, bool> alwaysTrue;

			private readonly GameObject origin;

			private readonly bool withSelf;

			private readonly Func<Transform, bool> descendIntoChildren;

			public DescendantsEnumerable(GameObject origin, bool withSelf, Func<Transform, bool> descendIntoChildren)
			{
			}

			public OfComponentEnumerable<T> OfComponent<T>() where T : Component
			{
				return default(OfComponentEnumerable<T>);
			}

			public void Destroy(bool useDestroyImmediate = false)
			{
			}

			public void Destroy(Func<GameObject, bool> predicate, bool useDestroyImmediate = false)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			private void ResizeArray<T>(ref int index, ref T[] array)
			{
			}

			private void DescendantsCore(ref Transform transform, ref Action<GameObject> action)
			{
			}

			private void DescendantsCore(ref Transform transform, ref int index, ref GameObject[] array)
			{
			}

			private void DescendantsCore(ref Func<GameObject, bool> filter, ref Transform transform, ref int index, ref GameObject[] array)
			{
			}

			private void DescendantsCore<T>(ref Func<GameObject, T> selector, ref Transform transform, ref int index, ref T[] array)
			{
			}

			private void DescendantsCore<T>(ref Func<GameObject, bool> filter, ref Func<GameObject, T> selector, ref Transform transform, ref int index, ref T[] array)
			{
			}

			private void DescendantsCore<TState, T>(ref Func<GameObject, TState> let, ref Func<TState, bool> filter, ref Func<TState, T> selector, ref Transform transform, ref int index, ref T[] array)
			{
			}

			public void ForEach(Action<GameObject> action)
			{
			}

			public int ToArrayNonAlloc(ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc(Func<GameObject, bool> filter, ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector, ref T[] array)
			{
				return 0;
			}

			public GameObject[] ToArray()
			{
				return null;
			}

			public GameObject[] ToArray(Func<GameObject, bool> filter)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector)
			{
				return null;
			}

			public GameObject First()
			{
				return null;
			}

			public GameObject FirstOrDefault()
			{
				return null;
			}
		}

		public struct BeforeSelfEnumerable : IEnumerable<GameObject>, IEnumerable
		{
			public struct Enumerator : IEnumerator<GameObject>, IEnumerator, IDisposable
			{
				private readonly int childCount;

				private readonly Transform originTransform;

				private bool canRun;

				private bool withSelf;

				private int currentIndex;

				private GameObject current;

				private Transform parent;

				public GameObject Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(Transform originTransform, bool withSelf, bool canRun)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			public struct OfComponentEnumerable<T> : IEnumerable<T>, IEnumerable where T : Component
			{
				private BeforeSelfEnumerable parent;

				public OfComponentEnumerable(ref BeforeSelfEnumerable parent)
				{
				}

				public OfComponentEnumerator<T> GetEnumerator()
				{
					return default(OfComponentEnumerator<T>);
				}

				private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
				{
					return null;
				}

				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}

				public void ForEach(Action<T> action)
				{
				}

				public T First()
				{
					return null;
				}

				public T FirstOrDefault()
				{
					return null;
				}

				public T[] ToArray()
				{
					return null;
				}

				public int ToArrayNonAlloc(ref T[] array)
				{
					return 0;
				}
			}

			public struct OfComponentEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : Component
			{
				private Enumerator enumerator;

				private T current;

				public T Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				public OfComponentEnumerator(ref BeforeSelfEnumerable parent)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			private readonly GameObject origin;

			private readonly bool withSelf;

			public BeforeSelfEnumerable(GameObject origin, bool withSelf)
			{
			}

			public OfComponentEnumerable<T> OfComponent<T>() where T : Component
			{
				return default(OfComponentEnumerable<T>);
			}

			public void Destroy(bool useDestroyImmediate = false)
			{
			}

			public void Destroy(Func<GameObject, bool> predicate, bool useDestroyImmediate = false)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public void ForEach(Action<GameObject> action)
			{
			}

			public int ToArrayNonAlloc(ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc(Func<GameObject, bool> filter, ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector, ref T[] array)
			{
				return 0;
			}

			public GameObject[] ToArray()
			{
				return null;
			}

			public GameObject[] ToArray(Func<GameObject, bool> filter)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector)
			{
				return null;
			}

			public GameObject First()
			{
				return null;
			}

			public GameObject FirstOrDefault()
			{
				return null;
			}
		}

		public struct AfterSelfEnumerable : IEnumerable<GameObject>, IEnumerable
		{
			public struct Enumerator : IEnumerator<GameObject>, IEnumerator, IDisposable
			{
				private readonly int childCount;

				private readonly Transform originTransform;

				private readonly bool canRun;

				private bool withSelf;

				private int currentIndex;

				private GameObject current;

				private Transform parent;

				public GameObject Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(Transform originTransform, bool withSelf, bool canRun)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			public struct OfComponentEnumerable<T> : IEnumerable<T>, IEnumerable where T : Component
			{
				private AfterSelfEnumerable parent;

				public OfComponentEnumerable(ref AfterSelfEnumerable parent)
				{
				}

				public OfComponentEnumerator<T> GetEnumerator()
				{
					return default(OfComponentEnumerator<T>);
				}

				private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
				{
					return null;
				}

				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}

				public void ForEach(Action<T> action)
				{
				}

				public T First()
				{
					return null;
				}

				public T FirstOrDefault()
				{
					return null;
				}

				public T[] ToArray()
				{
					return null;
				}

				public int ToArrayNonAlloc(ref T[] array)
				{
					return 0;
				}
			}

			public struct OfComponentEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : Component
			{
				private Enumerator enumerator;

				private T current;

				public T Current => null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				public OfComponentEnumerator(ref AfterSelfEnumerable parent)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}

				public void Reset()
				{
				}
			}

			private readonly GameObject origin;

			private readonly bool withSelf;

			public AfterSelfEnumerable(GameObject origin, bool withSelf)
			{
			}

			public OfComponentEnumerable<T> OfComponent<T>() where T : Component
			{
				return default(OfComponentEnumerable<T>);
			}

			public void Destroy(bool useDestroyImmediate = false)
			{
			}

			public void Destroy(Func<GameObject, bool> predicate, bool useDestroyImmediate = false)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public void ForEach(Action<GameObject> action)
			{
			}

			public int ToArrayNonAlloc(ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc(Func<GameObject, bool> filter, ref GameObject[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector, ref T[] array)
			{
				return 0;
			}

			public int ToArrayNonAlloc<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector, ref T[] array)
			{
				return 0;
			}

			public GameObject[] ToArray()
			{
				return null;
			}

			public GameObject[] ToArray(Func<GameObject, bool> filter)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<T>(Func<GameObject, bool> filter, Func<GameObject, T> selector)
			{
				return null;
			}

			public T[] ToArray<TState, T>(Func<GameObject, TState> let, Func<TState, bool> filter, Func<TState, T> selector)
			{
				return null;
			}

			public GameObject First()
			{
				return null;
			}

			public GameObject FirstOrDefault()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAncestors_003Ed__0 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private AncestorsEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CAncestors_003Ed__0(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003CAncestorsAndSelf_003Ed__1 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private AncestorsEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CAncestorsAndSelf_003Ed__1(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003CDescendants_003Ed__2 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private Func<Transform, bool> descendIntoChildren;

			public Func<Transform, bool> _003C_003E3__descendIntoChildren;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private DescendantsEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CDescendants_003Ed__2(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003CDescendantsAndSelf_003Ed__3 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private Func<Transform, bool> descendIntoChildren;

			public Func<Transform, bool> _003C_003E3__descendIntoChildren;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private DescendantsEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CDescendantsAndSelf_003Ed__3(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003CChildren_003Ed__4 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private ChildrenEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CChildren_003Ed__4(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003CChildrenAndSelf_003Ed__5 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private ChildrenEnumerable.Enumerator _003Ce_003E5__3;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CChildrenAndSelf_003Ed__5(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		private sealed class _003COfComponent_003Ed__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> source;

			public IEnumerable<GameObject> _003C_003E3__source;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003COfComponent_003Ed__7(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
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

		[IteratorStateMachine(typeof(_003CAncestors_003Ed__0))]
		public static IEnumerable<GameObject> Ancestors(this IEnumerable<GameObject> source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAncestorsAndSelf_003Ed__1))]
		public static IEnumerable<GameObject> AncestorsAndSelf(this IEnumerable<GameObject> source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDescendants_003Ed__2))]
		public static IEnumerable<GameObject> Descendants(this IEnumerable<GameObject> source, Func<Transform, bool> descendIntoChildren = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDescendantsAndSelf_003Ed__3))]
		public static IEnumerable<GameObject> DescendantsAndSelf(this IEnumerable<GameObject> source, Func<Transform, bool> descendIntoChildren = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CChildren_003Ed__4))]
		public static IEnumerable<GameObject> Children(this IEnumerable<GameObject> source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CChildrenAndSelf_003Ed__5))]
		public static IEnumerable<GameObject> ChildrenAndSelf(this IEnumerable<GameObject> source)
		{
			return null;
		}

		public static void Destroy(this IEnumerable<GameObject> source, bool useDestroyImmediate = false, bool detachParent = false)
		{
		}

		[IteratorStateMachine(typeof(_003COfComponent_003Ed__7<>))]
		public static IEnumerable<T> OfComponent<T>(this IEnumerable<GameObject> source) where T : Component
		{
			return null;
		}

		public static int ToArrayNonAlloc<T>(this IEnumerable<T> source, ref T[] array)
		{
			return 0;
		}

		private static GameObject GetGameObject<T>(T obj) where T : UnityEngine.Object
		{
			return null;
		}

		public static T Add<T>(this GameObject parent, T childOriginal, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] AddRange<T>(this GameObject parent, IEnumerable<T> childOriginals, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T AddFirst<T>(this GameObject parent, T childOriginal, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] AddFirstRange<T>(this GameObject parent, IEnumerable<T> childOriginals, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T AddBeforeSelf<T>(this GameObject parent, T childOriginal, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] AddBeforeSelfRange<T>(this GameObject parent, IEnumerable<T> childOriginals, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T AddAfterSelf<T>(this GameObject parent, T childOriginal, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] AddAfterSelfRange<T>(this GameObject parent, IEnumerable<T> childOriginals, TransformCloneType cloneType = TransformCloneType.KeepOriginal, bool? setActive = null, string specifiedName = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T MoveToLast<T>(this GameObject parent, T child, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] MoveToLastRange<T>(this GameObject parent, IEnumerable<T> childs, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T MoveToFirst<T>(this GameObject parent, T child, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] MoveToFirstRange<T>(this GameObject parent, IEnumerable<T> childs, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T MoveToBeforeSelf<T>(this GameObject parent, T child, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] MoveToBeforeSelfRange<T>(this GameObject parent, IEnumerable<T> childs, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T MoveToAfterSelf<T>(this GameObject parent, T child, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] MoveToAfterSelfRange<T>(this GameObject parent, IEnumerable<T> childs, TransformMoveType moveType = TransformMoveType.DoNothing, bool? setActive = null, bool setLayer = false) where T : UnityEngine.Object
		{
			return null;
		}

		public static void Destroy(this GameObject self, bool useDestroyImmediate = false, bool detachParent = false)
		{
		}

		public static GameObject Parent(this GameObject origin)
		{
			return null;
		}

		public static GameObject Child(this GameObject origin, string name)
		{
			return null;
		}

		public static ChildrenEnumerable Children(this GameObject origin)
		{
			return default(ChildrenEnumerable);
		}

		public static ChildrenEnumerable ChildrenAndSelf(this GameObject origin)
		{
			return default(ChildrenEnumerable);
		}

		public static AncestorsEnumerable Ancestors(this GameObject origin)
		{
			return default(AncestorsEnumerable);
		}

		public static AncestorsEnumerable AncestorsAndSelf(this GameObject origin)
		{
			return default(AncestorsEnumerable);
		}

		public static DescendantsEnumerable Descendants(this GameObject origin, Func<Transform, bool> descendIntoChildren = null)
		{
			return default(DescendantsEnumerable);
		}

		public static DescendantsEnumerable DescendantsAndSelf(this GameObject origin, Func<Transform, bool> descendIntoChildren = null)
		{
			return default(DescendantsEnumerable);
		}

		public static BeforeSelfEnumerable BeforeSelf(this GameObject origin)
		{
			return default(BeforeSelfEnumerable);
		}

		public static BeforeSelfEnumerable BeforeSelfAndSelf(this GameObject origin)
		{
			return default(BeforeSelfEnumerable);
		}

		public static AfterSelfEnumerable AfterSelf(this GameObject origin)
		{
			return default(AfterSelfEnumerable);
		}

		public static AfterSelfEnumerable AfterSelfAndSelf(this GameObject origin)
		{
			return default(AfterSelfEnumerable);
		}
	}
}
