using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
	public enum LoadingType
	{
		None = 0,
		Normal = 1,
		Fade = 2,
		FadeEffect = 3,
		FastFadeEffect = 4
	}

	public delegate void ManualFadeDelegate();

	[CompilerGenerated]
	private sealed class _003CCheckRemainPacket_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCheckRemainPacket_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CFadeOut_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

		private float _003Calpha_003E5__2;

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
		public _003CFadeOut_003Ed__48(int _003C_003E1__state)
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
	private sealed class _003CContinueFade_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CContinueFade_003Ed__49(int _003C_003E1__state)
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
	private sealed class _003CLoadLevel_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CLoadLevel_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CFadeIn_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

		private float _003Calpha_003E5__2;

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
		public _003CFadeIn_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CFade_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CFade_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CFadeEffect_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CFadeEffect_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CNoneEffect_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CNoneEffect_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CFastFadeEffect_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CFastFadeEffect_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CManualFadeEffect_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CManualFadeEffect_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CChangeSceneStart_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CChangeSceneStart_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CChangeSceneEnd_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneDirector _003C_003E4__this;

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
		public _003CChangeSceneEnd_003Ed__58(int _003C_003E1__state)
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

	private static SceneDirector _instance;

	private ManualFadeDelegate _manualFadeCallback;

	private SceneBase _curScene;

	private Texture2D _texture;

	private Color _drawColor;

	private bool _isChangeScene;

	private bool _isFade;

	private bool _isFastFade;

	private const float _fadeTime = 9f;

	private const float _fastFadeTime = 50f;

	private string _sceneName;

	private string _prevSceneName;

	private AsyncOperation _Async;

	private bool _isButtonMsgTracking;

	private DateTime _prevSendLogTime;

	private const double DELAY_SEND_LOG = 30.0;

	private float _checkLowMemoryTime;

	public static SceneDirector Instance => null;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SendCurrentSceneLog()
	{
	}

	public void InitSceneDirector()
	{
	}

	public void ChangeScreen()
	{
	}

	public static void ChangeScene(string sceneName, LoadingType loadingType)
	{
	}

	public static void EndLoading(string sceneName)
	{
	}

	public static string GetLastScene()
	{
		return null;
	}

	public static string GetPrevSceneName()
	{
		return null;
	}

	public string GetLastSceneName()
	{
		return null;
	}

	public void SetLastSceneName(string sceneName)
	{
	}

	public static LetterBox GetLetterBox()
	{
		return null;
	}

	public static SceneBase GetCurScene()
	{
		return null;
	}

	public void SetCurrentScene(SceneBase curScene)
	{
	}

	public void ForceChangeScene(string sceneName, LoadingType loadingType)
	{
	}

	private void LoadScene(string sceneName, LoadingType loadingType, bool isForceChangeScene = false)
	{
	}

	public void EndLoadingScene(string sceneName)
	{
	}

	public void EnterScene()
	{
	}

	public void ExitScene()
	{
	}

	public static void StartFade(ManualFadeDelegate manualFadeDelegate)
	{
	}

	public void StartFadeEffect(ManualFadeDelegate manualFadeDelegate)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void ApplicationResume()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnGUI()
	{
	}

	public bool IsChangeScene()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCheckRemainPacket_003Ed__47))]
	private IEnumerator CheckRemainPacket()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeOut_003Ed__48))]
	private IEnumerator FadeOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CContinueFade_003Ed__49))]
	private IEnumerator ContinueFade()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadLevel_003Ed__50))]
	private IEnumerator LoadLevel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeIn_003Ed__51))]
	private IEnumerator FadeIn()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFade_003Ed__52))]
	private IEnumerator Fade()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeEffect_003Ed__53))]
	private IEnumerator FadeEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNoneEffect_003Ed__54))]
	private IEnumerator NoneEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFastFadeEffect_003Ed__55))]
	private IEnumerator FastFadeEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CManualFadeEffect_003Ed__56))]
	private IEnumerator ManualFadeEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChangeSceneStart_003Ed__57))]
	private IEnumerator ChangeSceneStart()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChangeSceneEnd_003Ed__58))]
	private IEnumerator ChangeSceneEnd()
	{
		return null;
	}

	public void callBackQuit(GameObject obj, UIButton btn)
	{
	}

	public static void BuildButtonMessage(GameObject obj, MonoBehaviour target, string methodName = "Message")
	{
	}

	public void SetButtonMsgTracking(bool tracking)
	{
	}

	public void CheckLowMemory()
	{
	}

	private void ButtonMsg(UIButton btn)
	{
	}

	public void RestorePurchases()
	{
	}

	public void onTrackingCallback()
	{
	}
}
