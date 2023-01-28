using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class DataContainer : MonoBehaviour
{
	public delegate void PreLoadDelegate();

	[CompilerGenerated]
	private sealed class _003CPreLoadAssetBundle_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DataContainer _003C_003E4__this;

		private Dictionary<string, AssetBundleData>.Enumerator _003C_003E7__wrap1;

		private KeyValuePair<string, AssetBundleData> _003Cdata_003E5__3;

		private UnityWebRequest _003Cwww_003E5__4;

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
		public _003CPreLoadAssetBundle_003Ed__23(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static DataContainer _instance;

	private Dictionary<string, UnityEngine.Object> _dataContainer;

	private Dictionary<string, AssetBundle> _assetBundleContainer;

	private Dictionary<string, AssetBundle> _assetBundleContainerLocal;

	private bool _isLocalResource;

	private string _assetbundleBaseURL;

	private string _assetbundleTargetURL;

	private string _assetbundleManifest;

	private Dictionary<string, AssetBundleData> _assetbundleDataList;

	private PreLoadDelegate _preLoadDelegate;

	public static List<string> _failedLoadAssetBundleList;

	public static DataContainer Instance => null;

	public void InitAssetBundleURL(string baseURL, string targetPlatform, string manifest, bool isLocalResource)
	{
	}

	public void ClearData()
	{
	}

	public void ClearData(string assetBundleName)
	{
	}

	public bool IsLocalResource()
	{
		return false;
	}

	public void ClearAssetBundleDataList()
	{
	}

	public void AddAssetBundleData(string name, Hash128 hash, uint crc)
	{
	}

	public Dictionary<string, AssetBundleData> GetAssetBundleDataList()
	{
		return null;
	}

	public UnityEngine.Object GetData(string key)
	{
		return null;
	}

	public void PreLoadAssetBundleStart(PreLoadDelegate preLoadDelegate)
	{
	}

	[IteratorStateMachine(typeof(_003CPreLoadAssetBundle_003Ed__23))]
	public IEnumerator PreLoadAssetBundle()
	{
		return null;
	}

	public AssetBundle GetAssetBundle(string assetbundleName)
	{
		return null;
	}

	public void AddData(string key, UnityEngine.Object obj)
	{
	}

	public void AddAssetBundleLocal(string assetbundleName, AssetBundle assetBundle)
	{
	}

	public string GetAssetBundleManifest()
	{
		return null;
	}

	public string MakeAssetBundleManifestURL()
	{
		return null;
	}

	public string MakeAssetBundleURL(string assetbundleName)
	{
		return null;
	}
}
