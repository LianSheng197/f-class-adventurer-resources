using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics.Internal
{
	internal class BufferRevoked : IBuffer
	{
		public string UserID
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

		public string InstallID
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

		public string PlayerID
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

		public string SessionID
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

		public int Length => 0;

		public void ClearBuffer()
		{
		}

		public void ClearDiskCache()
		{
		}

		public List<Buffer.Token> CloneTokens()
		{
			return null;
		}

		public void InsertTokens(List<Buffer.Token> tokens)
		{
		}

		public void FlushToDisk()
		{
		}

		public void LoadFromDisk()
		{
		}

		public void PushArrayEnd()
		{
		}

		public void PushArrayStart(string name = null)
		{
		}

		public void PushBool(bool val, string name = null)
		{
		}

		public void PushDouble(double val, string name = null)
		{
		}

		public void PushEndEvent()
		{
		}

		public void PushEvent(Event evt)
		{
		}

		public void PushFloat(float val, string name = null)
		{
		}

		public void PushInt(int val, string name = null)
		{
		}

		public void PushInt64(long val, string name = null)
		{
		}

		public void PushObjectEnd()
		{
		}

		public void PushObjectStart(string name = null)
		{
		}

		public void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody = false)
		{
		}

		public void PushString(string val, string name = null)
		{
		}

		public void PushTimestamp(DateTime val, string name = null)
		{
		}

		public string Serialize(List<Buffer.Token> tokens)
		{
			return null;
		}
	}
}
