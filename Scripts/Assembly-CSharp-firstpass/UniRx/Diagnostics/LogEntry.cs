using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx.Diagnostics
{
	public struct LogEntry
	{
		public string LoggerName
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LogType LogType
		{
			[CompilerGenerated]
			readonly get
			{
				return default(LogType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime Timestamp
		{
			[CompilerGenerated]
			readonly get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnityEngine.Object Context
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string StackTrace
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object State
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LogEntry(string loggerName, LogType logType, DateTime timestamp, string message, UnityEngine.Object context = null, Exception exception = null, string stackTrace = null, object state = null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
