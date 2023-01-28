using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupManager")]
public class PopupManager : MonoBehaviour
{
	public enum PopupAnimation
	{
		None = 0,
		Open = 1,
		Close = 2,
		Max = 3
	}

	private const int BaseDepth = 5000;

	public const int DepthInterval = 50;

	private static PopupManager _instance;

	private Texture2D _backgroundTexture;

	private float _allCloseTime;

	private Dictionary<PopupAnimation, AnimationClip> _animationList;

	private List<string> _path;

	private Dictionary<string, int> _forceDepth;

	private List<string> _ignoreClose;

	private Dictionary<string, GameObject> _prefabList;

	private Dictionary<string, GameObject> _list;

	private Dictionary<string, PopupBase> _scriptList;

	public static PopupManager Instance => null;

	private void Update()
	{
	}

	private void InitPopupManager()
	{
	}

	private void PreLoadPopupAnimation()
	{
	}

	private GameObject GetPopupPrefab(string popupName)
	{
		return null;
	}

	public string GetPopupName<T>() where T : PopupBase
	{
		return null;
	}

	public string GetPopupName(Type type)
	{
		return null;
	}

	public string GetPopupName(GameObject popup)
	{
		return null;
	}

	public T Show<T>(PopupAnimation openAnimation = PopupAnimation.Open) where T : PopupBase
	{
		return null;
	}

	public PopupBase Show(Type type, PopupAnimation openAnimation = PopupAnimation.Open)
	{
		return null;
	}

	public void AllActivePopup(bool isShow, GameObject ignore = null)
	{
	}

	public void SetCloseAllPopup()
	{
	}

	public void CloseAllPopup()
	{
	}

	public void Close<T>(PopupAnimation closeAnimation = PopupAnimation.Close) where T : PopupBase
	{
	}

	public void Close(GameObject popup, PopupAnimation closeAnimation = PopupAnimation.Close)
	{
	}

	public void Close(GameObject popup, string closeAni)
	{
	}

	private void CloseAnimationEnd(GameObject obj)
	{
	}

	public PopupGuide Show(AttachGuide attach)
	{
		return null;
	}

	private void SetUnloadUnusedAssets(PopupBase popupBase)
	{
	}

	private void UnloadUnusedAssets()
	{
	}

	public GameObject GetTopPopup()
	{
		return null;
	}

	public bool CloseTopPopup()
	{
		return false;
	}

	public void AddForceDepth(string popupName, int depth)
	{
	}

	private int GetForceDepth(string popupName)
	{
		return 0;
	}

	private int GetNextPopupDepth(string popupName)
	{
		return 0;
	}

	public bool CheckOpenPopup()
	{
		return false;
	}

	public int CheckOpenPopupCount()
	{
		return 0;
	}

	public bool IsOpenPopup(string popupName)
	{
		return false;
	}

	public bool IsOpenPopup<T>() where T : PopupBase
	{
		return false;
	}

	public static bool IsOpen<T>() where T : PopupBase
	{
		return false;
	}

	public GameObject GetPopup<T>() where T : PopupBase
	{
		return null;
	}

	public GameObject FindPopup(string popupName)
	{
		return null;
	}

	public T GetPopupScript<T>() where T : PopupBase
	{
		return null;
	}

	public void PopupInvoke(string methodName, float time = 0.2f)
	{
	}

	private void SetupPopupAnimation(GameObject popupObj)
	{
	}

	private void SetupInteraction(PopupBase popupBase, GameObject popupObj)
	{
	}

	private void UpdateSoundVolume(GameObject popupObj)
	{
	}

	private void ImmediatelyDestroyEffect(GameObject popup)
	{
	}
}
