using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SoonsoonData
{
	[Serializable]
	public class SoonData
	{
		public List<Dictionary<string, bool>> packageList;
	}

	[CompilerGenerated]
	private sealed class _003CLoadData_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SoonsoonData _003C_003E4__this;

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
		public _003CLoadData_003Ed__12(int _003C_003E1__state)
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

	private static SoonsoonData instance;

	public SoonData _soonData2;

	public SPUM_Manager _spumManager;

	public bool _gifAlphaTrigger;

	public Color _gifBasicColor;

	public Color _alphaColor;

	public static SoonsoonData Instance => null;

	private SoonsoonData()
	{
	}

	public void SaveData()
	{
	}

	private void FileSaveToPrefab()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__12))]
	public IEnumerator LoadData()
	{
		return null;
	}

	public void LoadProcess()
	{
	}

	public void SavePackageData()
	{
	}

	public void LoadPackageData()
	{
	}
}
