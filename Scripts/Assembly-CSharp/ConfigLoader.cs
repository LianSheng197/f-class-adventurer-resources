using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConfigLoader : MonoBehaviour
{
	public enum eType
	{
		Envrionment = 0,
		Connect = 1,
		ParticialConnect = 2,
		AssetBundleCRC = 3
	}

	public delegate void ResultDownLoadConfig(bool isResult, string strResult);

	[CompilerGenerated]
	private sealed class _003CDownLoadConfig_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ConfigLoader _003C_003E4__this;

		public eType type;

		public ResultDownLoadConfig del;

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
		public _003CDownLoadConfig_003Ed__12(int _003C_003E1__state)
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

	private static ConfigLoader _instance;

	public Dictionary<eType, string> _strConfig;

	private eType _lastType;

	private int _failedCount;

	private const int _failedMaxCount = 20;

	public static ConfigLoader Instance => null;

	private void End(eType type, bool isResult, ResultDownLoadConfig del, string url, string strResult)
	{
	}

	public string GetConfigURL(eType type, int majorVer, int middleVer, int minorVer)
	{
		return null;
	}

	public void GetDownLoadConfig(eType type, ResultDownLoadConfig del)
	{
	}

	[IteratorStateMachine(typeof(_003CDownLoadConfig_003Ed__12))]
	private IEnumerator DownLoadConfig(eType type, string url, ResultDownLoadConfig del)
	{
		return null;
	}

	public void GetDownLoadParticialConnectConfig(ResultDownLoadConfig del)
	{
	}

	public void GetAssetBundleCRCConfig(ResultDownLoadConfig del)
	{
	}

	private string GetConfig()
	{
		return null;
	}

	public string GetConfigString()
	{
		return null;
	}
}
