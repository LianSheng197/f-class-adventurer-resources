using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class ResManager : MonoBehaviour
{
	public delegate void CallBackClearResrouce();

	[CompilerGenerated]
	private sealed class _003CCoroutineClearResource_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResManager _003C_003E4__this;

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
		public _003CCoroutineClearResource_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CCoroutineUnloadUnusedAssets_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResManager _003C_003E4__this;

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
		public _003CCoroutineUnloadUnusedAssets_003Ed__48(int _003C_003E1__state)
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

	private static ResManager _instance;

	public static List<string> _ignoreFontName;

	public static long maximumAvailableDiskSpace;

	private CallBackClearResrouce _callBackClearResource;

	private float _unloadUnusedAssetsTime;

	private bool _isUnloadUnusedAssets;

	private bool _isLowMemoryDevice;

	public static ResManager Instance => null;

	public void InitResManager()
	{
	}

	public static void ClearResource(CallBackClearResrouce callBackClearResource)
	{
	}

	public static void UnloadUnusedAssets()
	{
	}

	public static UnityEngine.Object Get(string path, string name)
	{
		return null;
	}

	public static T GetTypeResources<T>(string path, string name) where T : UnityEngine.Object
	{
		return null;
	}

	public static List<T> GetTypeResourcesAll<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	public static GameObject GetObject(string path, string name)
	{
		return null;
	}

	public static GameObject GetObject_Inst(string path, string name)
	{
		return null;
	}

	public static GameObject GetObjectDirect(string path, string name)
	{
		return null;
	}

	public static void ChangeLayersRecursive(Transform form, string layer)
	{
	}

	public static UIAtlas GetAtlas(string path, string name)
	{
		return null;
	}

	public static NGUIAtlas GetNGUIAtlas(string path, string name)
	{
		return null;
	}

	public static void SetAtlas(UISprite sprite, SpriteData data)
	{
	}

	public static void SetAtlas(UISprite sprite, string folder, string atlas)
	{
	}

	public static TextAsset GetText(string path, string name)
	{
		return null;
	}

	public static AnimationClip GetAnimationClip(string path, string name)
	{
		return null;
	}

	public static AudioClip GetAudioClip(string path, string name)
	{
		return null;
	}

	public static Texture2D GetDownloadTexture(string url)
	{
		return null;
	}

	public static Texture2D GetTexture2D(string path, string name)
	{
		return null;
	}

	public static Sprite GetSprite(string path, string name)
	{
		return null;
	}

	public static void SetTexture2D(UITexture tex, TextureData data)
	{
	}

	public static SkeletonDataAsset GetSkeletonDataAsset(string path, string name, bool customMaterial)
	{
		return null;
	}

	public static void ReleaseSkeletonDataAsset(SkeletonDataAsset assetData)
	{
	}

	public static Material GetMaterial(string path, string name)
	{
		return null;
	}

	public static UIFont GetUIFont(string path, string name)
	{
		return null;
	}

	public static void UpdateSoundVolume(GameObject obj)
	{
	}

	public static UIFont GetUIFont()
	{
		return null;
	}

	public static void UpdateUIFont(GameObject obj)
	{
	}

	public UnityEngine.Object GetResource(string path, string name)
	{
		return null;
	}

	public T TypeResources<T>(string path, string name) where T : UnityEngine.Object
	{
		return null;
	}

	public List<T> TypeResourcesAll<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	private void Update()
	{
	}

	public void ClearAssetBundle(string assetBundleName)
	{
	}

	private void StartClearResource(CallBackClearResrouce callBackClearResource)
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutineClearResource_003Ed__44))]
	private IEnumerator CoroutineClearResource()
	{
		return null;
	}

	public void SetUnloadUnusedAssets()
	{
	}

	public void CancelUnloadUnusedAssets()
	{
	}

	public void StartUnloadUnusedAssets()
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutineUnloadUnusedAssets_003Ed__48))]
	private IEnumerator CoroutineUnloadUnusedAssets()
	{
		return null;
	}

	public bool IsLowMemoryDevice()
	{
		return false;
	}
}
