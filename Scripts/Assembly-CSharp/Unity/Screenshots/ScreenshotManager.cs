using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Screenshots
{
	public class ScreenshotManager
	{
		private class ScreenshotOperation
		{
			public Action<int, byte[]> Callback
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

			public byte[] Data
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

			public int FrameNumber
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

			public bool IsAwaiting
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

			public bool IsComplete
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

			public object Source
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

			public void Use()
			{
			}
		}

		private Action<byte[], object> screenshotCallbackDelegate;

		private List<ScreenshotOperation> screenshotOperations;

		private ScreenshotRecorder screenshotRecorder;

		private ScreenshotOperation GetScreenshotOperation()
		{
			return null;
		}

		public void OnEndOfFrame()
		{
		}

		private void ScreenshotCallback(byte[] data, object state)
		{
		}

		public void TakeScreenshot(object source, int frameNumber, int maximumWidth, int maximumHeight, Action<int, byte[]> callback)
		{
		}
	}
}
