using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SkeletonGhostRenderer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFade_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonGhostRenderer _003C_003E4__this;

			private int _003Ct_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
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
			public _003CFade_003Ed__8(int _003C_003E1__state)
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
		}

		[CompilerGenerated]
		private sealed class _003CFadeAdditive_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonGhostRenderer _003C_003E4__this;

			private Color32 _003Cblack_003E5__2;

			private int _003Ct_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
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
			public _003CFadeAdditive_003Ed__9(int _003C_003E1__state)
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
		}

		public float fadeSpeed;

		private Color32[] colors;

		private Color32 black;

		private MeshFilter meshFilter;

		private MeshRenderer meshRenderer;

		private void Awake()
		{
		}

		public void Initialize(Mesh mesh, Material[] materials, Color32 color, bool additive, float speed, int sortingLayerID, int sortingOrder)
		{
		}

		private void CopyMesh(Mesh source, Mesh destination)
		{
		}

		[IteratorStateMachine(typeof(_003CFade_003Ed__8))]
		private IEnumerator Fade()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeAdditive_003Ed__9))]
		private IEnumerator FadeAdditive()
		{
			return null;
		}

		public void Cleanup()
		{
		}
	}
}
