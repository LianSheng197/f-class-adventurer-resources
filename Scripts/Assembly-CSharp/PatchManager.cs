using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class PatchManager : MonoBehaviour
{
	public enum PATCH_STATE
	{
		NONE = 0,
		GET_PATCH_CHECK = 1,
		UPDATE_PATCH = 2,
		END = 3,
		ERROR_PATCHINFO = 4,
		ERROR_PATCHDATA_LIST_EMPTY = 5,
		ERROR_PATCHDATA_GET_SIZE = 6,
		ERROR_PATCHDATA_DOWNLOAD_ASSET_LIST = 7,
		ERROR_PATCHDATA_DOWNLOAD_ASSET = 8,
		ERROR_SIZE = 9
	}

	public delegate void PatchDelegate(PATCH_STATE state);

	[CompilerGenerated]
	private sealed class _003CGetPatchInfo_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatchManager _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CGetPatchInfo_003Ed__25(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDownLoadAssetBundleList_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatchManager _003C_003E4__this;

		private int _003CtotalCount_003E5__2;

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
		public _003CDownLoadAssetBundleList_003Ed__27(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDownloadAssetBundle_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string assetBundleName;

		public PatchManager _003C_003E4__this;

		public Hash128 hash;

		public uint crc;

		private string _003Curl_003E5__2;

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
		public _003CDownloadAssetBundle_003Ed__28(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CGetDownLoadListSize_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatchManager _003C_003E4__this;

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
		public _003CGetDownLoadListSize_003Ed__29(int _003C_003E1__state)
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

	private static PatchManager _instance;

	private PatchDelegate _delegate;

	private PATCH_STATE _state;

	private bool _patchResult;

	private int _curPatchCount;

	private List<AssetBundleData> _downloadList;

	private long _downloadSize;

	private UnityWebRequest _currentWWW;

	private GameObject _patchState;

	private UILabel _patchProgress;

	private UISlider _patchSlider;

	public Dictionary<string, uint> _AssetBundleCRCList;

	public int _FailedCount;

	private int _curBytePerSecond;

	public PATCH_STATE _lastFailedStep;

	public static PatchManager Instance => null;

	private void Update()
	{
	}

	public int GetCurrentPatchProgress()
	{
		return 0;
	}

	private void UpdatePatchState(PATCH_STATE state)
	{
	}

	public void CheckPatchInfo(PatchDelegate patchDelegate = null)
	{
	}

	private void CheckPatchData()
	{
	}

	public bool CheckExistPatch()
	{
		return false;
	}

	public int GetPatchCount()
	{
		return 0;
	}

	public void UpdatePatch()
	{
	}

	[IteratorStateMachine(typeof(_003CGetPatchInfo_003Ed__25))]
	private IEnumerator GetPatchInfo()
	{
		return null;
	}

	public void DownLoadListSize()
	{
	}

	[IteratorStateMachine(typeof(_003CDownLoadAssetBundleList_003Ed__27))]
	private IEnumerator DownLoadAssetBundleList()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownloadAssetBundle_003Ed__28))]
	public IEnumerator DownloadAssetBundle(string assetBundleName, Hash128 hash, uint crc)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetDownLoadListSize_003Ed__29))]
	private IEnumerator GetDownLoadListSize()
	{
		return null;
	}

	public long GetDownLoadSize()
	{
		return 0L;
	}

	public int GetDownLoadTime()
	{
		return 0;
	}

	public bool RetryPatch(PATCH_STATE state)
	{
		return false;
	}

	public void SetCRC(Dictionary<byte, Dictionary<string, string>> ConfigList)
	{
	}

	public uint GetAssetBundleCRC(string assetBundleName)
	{
		return 0u;
	}
}
