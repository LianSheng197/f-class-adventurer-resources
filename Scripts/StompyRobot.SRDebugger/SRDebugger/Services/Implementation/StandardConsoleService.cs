using System;
using System.Runtime.CompilerServices;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IConsoleService))]
	public class StandardConsoleService : IConsoleService, IDisposable
	{
		private readonly bool _collapseEnabled;

		private bool _hasCleared;

		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries;

		private CircularBuffer<ConsoleEntry> _consoleEntries;

		private readonly object _threadLock;

		private ILogHandler _expectedLogHandler;

		public int ErrorCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int WarningCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int InfoCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool LoggingEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LogHandlerIsOverriden => false;

		public IReadOnlyList<ConsoleEntry> Entries => null;

		public IReadOnlyList<ConsoleEntry> AllEntries => null;

		public event ConsoleUpdatedEventHandler Updated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ConsoleUpdatedEventHandler Error
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		protected void OnEntryAdded(ConsoleEntry entry)
		{
		}

		protected void OnEntryDuplicated(ConsoleEntry entry)
		{
		}

		private void OnUpdated()
		{
		}

		private void UnityLogCallback(string condition, string stackTrace, LogType type)
		{
		}

		private void AdjustCounter(LogType type, int amount)
		{
		}
	}
}
