using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	internal class ObscuredFilePrefsExamples : MonoBehaviour
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CPrewarmAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CSetBytesPrefAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ObscuredFilePrefsExamples _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetBytesPrefAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ObscuredFilePrefsExamples _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CLoadPrefsAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ObscuredFilePrefsExamples _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CSaveAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ObscuredFilePrefsExamples _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private const string StringKey = "string example";

		private const string ByteArrayKey = "byte[] example";

		[SerializeField]
		private string dataToSave;

		[SerializeField]
		private long bytesToSave;

		private uint savedBytesHash;

		private uint loadedBytesHash;

		private bool isFileSaving;

		private bool isFileLoading;

		private bool isSettingBytes;

		private bool isGettingBytes;

		private readonly string[] sizes;

		private bool isLoadedGUI;

		private bool isFileLoadingGUI;

		private bool isSettingBytesGUI;

		private bool isGettingBytesGUI;

		private bool isFileSavingGUI;

		private bool unloadPrefs;

		private bool loadPrefs;

		private bool loadPrefsAsync;

		private bool setStringPref;

		private bool getStringPref;

		private string LoadedData
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

		private bool NotGenuine
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

		private bool FromAnotherDevice
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

		private bool IsExists => false;

		private bool IsLoaded => false;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CPrewarmAsync_003Ed__27))]
		private void PrewarmAsync()
		{
		}

		private void SetBytesPref()
		{
		}

		private void GetBytesPref()
		{
		}

		[AsyncStateMachine(typeof(_003CSetBytesPrefAsync_003Ed__30))]
		private void SetBytesPrefAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CGetBytesPrefAsync_003Ed__31))]
		private void GetBytesPrefAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadPrefsAsync_003Ed__32))]
		private void LoadPrefsAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CSaveAsync_003Ed__33))]
		private void SaveAsync()
		{
		}

		private void LoadPrefs()
		{
		}

		private void UnloadPrefs()
		{
		}

		private bool HasKey(string key)
		{
			return false;
		}

		private ICollection<string> GetKeys()
		{
			return null;
		}

		private void SetStringPref()
		{
		}

		private void GetStringPref()
		{
		}

		private void DeleteAllPrefs()
		{
		}

		private void OnNotGenuineDataDetected()
		{
		}

		private void OnDataFromAnotherDeviceDetected()
		{
		}

		private void Save()
		{
		}

		public void DrawUI()
		{
		}

		private void DrawStatusPanel()
		{
		}

		private void DrawLoadUnloadPanel()
		{
		}

		private void DrawStringPrefPanel()
		{
		}

		private void DrawBinaryPrefPanel()
		{
		}

		private void DrawSavePanel()
		{
		}

		public string FormatBytes(double bytes)
		{
			return null;
		}
	}
}
