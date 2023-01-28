using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Moments.Encoder;
using UnityEngine;

namespace Moments
{
	[AddComponentMenu("Miscellaneous/Moments Recorder")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	public sealed class Recorder : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPreProcess_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Recorder _003C_003E4__this;

			public string filename;

			private string _003Cfilepath_003E5__2;

			private List<GifFrame> _003Cframes_003E5__3;

			private Texture2D _003Ctemp_003E5__4;

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
			public _003CPreProcess_003Ed__40(int _003C_003E1__state)
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

		[Min(8f)]
		[SerializeField]
		private int m_Width;

		[Min(8f)]
		[SerializeField]
		private int m_Height;

		[SerializeField]
		private bool m_AutoAspect;

		[Range(1f, 30f)]
		[SerializeField]
		private int m_FramePerSecond;

		[Min(-1f)]
		[SerializeField]
		private int m_Repeat;

		[SerializeField]
		[Range(1f, 100f)]
		private int m_Quality;

		[SerializeField]
		[Min(0.1f)]
		private float m_BufferSize;

		public ThreadPriority WorkerPriority;

		public Action OnPreProcessingDone;

		public Action<int, float> OnFileSaveProgress;

		public Action<int, string> OnFileSaved;

		private int m_MaxFrameCount;

		private float m_Time;

		private float m_TimePerFrame;

		private Queue<RenderTexture> m_Frames;

		private RenderTexture m_RecycledRenderTexture;

		private ReflectionUtils<Recorder> m_ReflectionUtils;

		public RecorderState State
		{
			[CompilerGenerated]
			get
			{
				return default(RecorderState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string SaveFolder
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float EstimatedMemoryUse => 0f;

		public void Setup(bool autoAspect, int width, int height, int fps, float bufferSize, int repeat, int quality)
		{
		}

		public void Pause()
		{
		}

		public void Record()
		{
		}

		public void FlushMemory()
		{
		}

		public void Save()
		{
		}

		public void Save(string filename)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void Init()
		{
		}

		public void ComputeHeight()
		{
		}

		private void Flush(UnityEngine.Object obj)
		{
		}

		private string GenerateFileName()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPreProcess_003Ed__40))]
		private IEnumerator PreProcess(string filename)
		{
			return null;
		}

		private GifFrame ToGifFrame(RenderTexture source, Texture2D target)
		{
			return null;
		}
	}
}
