using System;
using System.Collections.Generic;
using System.Threading;
using Moments.Encoder;

namespace Moments
{
	internal sealed class Worker
	{
		private static int workerId;

		private Thread m_Thread;

		private int m_Id;

		internal List<GifFrame> m_Frames;

		internal GifEncoder m_Encoder;

		internal string m_FilePath;

		internal Action<int, string> m_OnFileSaved;

		internal Action<int, float> m_OnFileSaveProgress;

		internal Worker(ThreadPriority priority)
		{
		}

		internal void Start()
		{
		}

		private void Run()
		{
		}
	}
}
