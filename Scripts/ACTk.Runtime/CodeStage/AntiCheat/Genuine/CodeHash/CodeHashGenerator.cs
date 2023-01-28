using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public class CodeHashGenerator : KeepAliveBehaviour<CodeHashGenerator>, ICodeHashGenerator
	{
		[CompilerGenerated]
		private sealed class _003CCalculationAwaiter_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CodeHashGenerator _003C_003E4__this;

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
			public _003CCalculationAwaiter_003Ed__20(int _003C_003E1__state)
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

		private readonly WaitForSeconds cachedWaitForSeconds;

		private BaseWorker currentWorker;

		public HashGeneratorResult LastResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsBusy => false;

		public static event HashGeneratorResultHandler HashGenerated
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

		public static bool IsTargetPlatformCompatible()
		{
			return false;
		}

		public static CodeHashGenerator AddToSceneOrGetExisting()
		{
			return null;
		}

		public static ICodeHashGenerator Generate()
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersAndroid(bool il2Cpp)
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersStandaloneWindows(bool il2Cpp)
		{
			return null;
		}

		private ICodeHashGenerator CodeStage_002EAntiCheat_002EGenuine_002ECodeHash_002EICodeHashGenerator_002EGenerate()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private ICodeHashGenerator GenerateInternal()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCalculationAwaiter_003Ed__20))]
		private IEnumerator CalculationAwaiter()
		{
			return null;
		}

		public CodeHashGenerator()
		{
			((KeepAliveBehaviour<>)(object)this)._002Ector();
		}
	}
}
