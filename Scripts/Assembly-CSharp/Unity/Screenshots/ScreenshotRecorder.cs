using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Unity.Screenshots
{
	public class ScreenshotRecorder
	{
		private class ScreenshotOperation
		{
			public WaitCallback EncodeCallbackDelegate;

			public Action<AsyncGPUReadbackRequest> ScreenshotCallbackDelegate;

			public Action<byte[], object> Callback
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

			public int Height
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int Identifier
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool IsInUse
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int MaximumHeight
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int MaximumWidth
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public NativeArray<byte> NativeData
			{
				[CompilerGenerated]
				get
				{
					return default(NativeArray<byte>);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Texture Source
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

			public object State
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

			public ScreenshotType Type
			{
				[CompilerGenerated]
				get
				{
					return default(ScreenshotType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int Width
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			private void EncodeCallback(object state)
			{
			}

			private void SavePngToDisk(byte[] byteData)
			{
			}

			private void ScreenshotCallback(AsyncGPUReadbackRequest request)
			{
			}
		}

		private static int nextIdentifier;

		private List<ScreenshotOperation> operationPool;

		private ScreenshotOperation GetOperation()
		{
			return null;
		}

		public void Screenshot(int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		public void Screenshot(Camera source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		public void Screenshot(RenderTexture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		public void Screenshot(Texture2D source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		private void ScreenshotInternal(Texture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}
	}
}
