using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Tabs
{
	public class ConsoleTabController : SRMonoBehaviourEx
	{
		public enum CopyToClipboardStates
		{
			Hidden = 0,
			Visible = 1,
			Activated = 2
		}

		[CompilerGenerated]
		private sealed class _003CFadeCopyButton_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConsoleTabController _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CFadeCopyButton_003Ed__40(int _003C_003E1__state)
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

		private const int MaxLength = 2600;

		private Canvas _consoleCanvas;

		private bool _isDirty;

		private static bool _hasWarnedAboutLogHandler;

		private static bool _hasWarnedAboutLoggingDisabled;

		[RequiredField]
		public ConsoleLogControl ConsoleLogControl;

		[RequiredField]
		public Toggle PinToggle;

		[RequiredField]
		public ScrollRect StackTraceScrollRect;

		[RequiredField]
		public Text StackTraceText;

		[RequiredField]
		public Toggle ToggleErrors;

		[RequiredField]
		public Text ToggleErrorsText;

		[RequiredField]
		public Toggle ToggleInfo;

		[RequiredField]
		public Text ToggleInfoText;

		[RequiredField]
		public Toggle ToggleWarnings;

		[RequiredField]
		public Text ToggleWarningsText;

		[RequiredField]
		public GameObject CopyToClipboardContainer;

		[RequiredField]
		public GameObject CopyToClipboardButton;

		[RequiredField]
		public GameObject CopyToClipboardMessage;

		[RequiredField]
		public CanvasGroup CopyToClipboardMessageCanvasGroup;

		[RequiredField]
		public GameObject LoggingIsDisabledCanvasGroup;

		[RequiredField]
		public GameObject LogHandlerHasBeenOverridenGroup;

		[RequiredField]
		public Toggle FilterToggle;

		[RequiredField]
		public InputField FilterField;

		[RequiredField]
		public GameObject FilterBarContainer;

		private ConsoleEntry _selectedItem;

		private Coroutine _fadeButtonCoroutine;

		protected override void Start()
		{
		}

		private void FilterToggleValueChanged(bool isOn)
		{
		}

		private void FilterValueChanged(string filterText)
		{
		}

		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		private void PinToggleValueChanged(bool isOn)
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void ConsoleLogSelectedItemChanged(object item)
		{
		}

		protected override void Update()
		{
		}

		private void PopulateStackTraceArea(ConsoleEntry entry)
		{
		}

		public void CopyToClipboard()
		{
		}

		private void SetCopyToClipboardButtonState(CopyToClipboardStates state)
		{
		}

		[IteratorStateMachine(typeof(_003CFadeCopyButton_003Ed__40))]
		private IEnumerator FadeCopyButton()
		{
			return null;
		}

		private void StopAnimations()
		{
		}

		private void Refresh()
		{
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		public void Clear()
		{
		}

		public void LogHandlerHasBeenOverridenOkayButtonPress()
		{
		}

		public void LoggingDisableCloseAndIgnorePressed()
		{
		}

		public void LoggingDisableReenablePressed()
		{
		}
	}
}
