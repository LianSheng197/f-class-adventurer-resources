using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.Detectors
{
	[HelpURL("https://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
	public class TimeCheatingDetector : ACTkDetectorBase<TimeCheatingDetector>
	{
		public delegate void OnlineTimeCallback(OnlineTimeResult result);

		public delegate void TimeCheatingDetectorEventHandler(CheckResult result, ErrorKind error);

		public struct OnlineTimeResult
		{
			[Obsolete("Please use Success property instead")]
			public bool success;

			[Obsolete("Please use Error property instead")]
			public string error;

			[Obsolete("Please use ErrorResponseCode property instead")]
			public long errorResponseCode;

			[Obsolete("Please use OnlineSecondsUtc property instead")]
			public double onlineSecondsUtc;

			[Obsolete("Please use OnlineDateTimeUtc property instead")]
			public DateTime onlineDateTimeUtc;

			public bool Success => false;

			public string Error => null;

			public long ErrorResponseCode => 0L;

			public double OnlineSecondsUtc => 0.0;

			public DateTime OnlineDateTimeUtc => default(DateTime);

			internal void SetTime(double secondsUtc, DateTime dateTimeUtc)
			{
			}

			internal void SetError(string errorText, long responseCode = -1L)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public enum CheckResult
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}

		public enum ErrorKind
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}

		public enum RequestMethod
		{
			Head = 0,
			Get = 1
		}

		[CompilerGenerated]
		private sealed class _003CGetOnlineTimeCoroutine_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public OnlineTimeCallback callback;

			public RequestMethod method;

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
			public _003CGetOnlineTimeCoroutine_003Ed__51(int _003C_003E1__state)
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
		private sealed class _003CGetOnlineTimeCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Uri uri;

			public RequestMethod method;

			public OnlineTimeCallback callback;

			private OnlineTimeResult _003Cresult_003E5__2;

			private UnityWebRequest _003Cwr_003E5__3;

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
			public _003CGetOnlineTimeCoroutine_003Ed__52(int _003C_003E1__state)
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

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetOnlineTimeTask_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<OnlineTimeResult> _003C_003Et__builder;

			public Uri uri;

			public RequestMethod method;

			private OnlineTimeResult _003Cresult_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private UnityWebRequest _003Cwr_003E5__3;

			private UnityWebRequestAsyncOperation _003CasyncOperation_003E5__4;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CForceCheckEnumerator_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeCheatingDetector _003C_003E4__this;

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
			public _003CForceCheckEnumerator_003Ed__60(int _003C_003E1__state)
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

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CForceCheckTask_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CheckResult> _003C_003Et__builder;

			public TimeCheatingDetector _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCheckForCheat_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeCheatingDetector _003C_003E4__this;

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
			public _003CCheckForCheat_003Ed__68(int _003C_003E1__state)
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

		public const string ComponentName = "Time Cheating Detector";

		private const string LogPrefix = "[ACTk] Time Cheating Detector: ";

		private const int DefaultTimeoutSeconds = 10;

		private static readonly WaitForEndOfFrame CachedEndOfFrame;

		private static bool gettingOnlineTime;

		private static int sdkLevel;

		[Header("Request settings")]
		[SerializeField]
		[Tooltip("Absolute URL which will return correct datetime in response headers (you may use popular web servers like google.com, microsoft.com etc.).")]
		private string requestUrl;

		[Tooltip("Method to use for url request. Use Head method if possible and fall back to get if server does not reply or block head requests.")]
		public RequestMethod requestMethod;

		[Tooltip("Online time request timeout in seconds.")]
		public int timeoutSeconds;

		[Header("Settings in minutes")]
		[Tooltip("Time (in minutes) between detector checks.")]
		[Range(0f, 60f)]
		public float interval;

		[Tooltip("Maximum allowed difference between subsequent measurements, in minutes.")]
		[FormerlySerializedAs("threshold")]
		[Range(10f, 180f)]
		public int realCheatThreshold;

		[Range(1f, 180f)]
		[Tooltip("Maximum allowed difference between local and online time, in minutes.")]
		public int wrongTimeThreshold;

		[Tooltip("Ignore case when time changes to be in sync with online correct time. Wrong time threshold is taken into account.")]
		public bool ignoreSetCorrectTime;

		private readonly string onlineOfflineDifferencePrefsKey;

		private Uri cachedUri;

		private TimeCheatingDetectorEventHandler cheatChecked;

		private float timeElapsed;

		private bool updateAfterPause;

		private double lastOnlineSecondsUtc;

		[NonSerialized]
		[Obsolete("Use wrongTimeThreshold instead.", true)]
		public int threshold;

		[NonSerialized]
		[Obsolete("Use requestUrl instead", true)]
		public string timeServer;

		public string RequestUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ErrorKind LastError
		{
			[CompilerGenerated]
			get
			{
				return default(ErrorKind);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CheckResult LastResult
		{
			[CompilerGenerated]
			get
			{
				return default(CheckResult);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsCheckingForCheat
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event TimeCheatingDetectorEventHandler CheatChecked
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

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action<ErrorKind> Error
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

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action CheckPassed
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

		protected override string GetComponentName()
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void Update()
		{
		}

		public static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static TimeCheatingDetector StartDetection(TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		public static TimeCheatingDetector StartDetection(float intervalMinutes, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		[IteratorStateMachine(typeof(_003CGetOnlineTimeCoroutine_003Ed__51))]
		public static IEnumerator GetOnlineTimeCoroutine(string url, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetOnlineTimeCoroutine_003Ed__52))]
		public static IEnumerator GetOnlineTimeCoroutine(Uri uri, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		public static Task<OnlineTimeResult> GetOnlineTimeTask(string url, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetOnlineTimeTask_003Ed__54))]
		public static Task<OnlineTimeResult> GetOnlineTimeTask(Uri uri, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		private static UnityWebRequest GetWebRequest(Uri uri, RequestMethod method)
		{
			return null;
		}

		private static void FillRequestResult(UnityWebRequest request, ref OnlineTimeResult result)
		{
		}

		private static Uri UrlToUri(string url)
		{
			return null;
		}

		private static bool TryGetDate(string source, out DateTime date)
		{
			date = default(DateTime);
			return false;
		}

		public bool ForceCheck()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CForceCheckEnumerator_003Ed__60))]
		public IEnumerator ForceCheckEnumerator()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CForceCheckTask_003Ed__61))]
		public Task<CheckResult> ForceCheckTask()
		{
			return null;
		}

		private TimeCheatingDetector StartDetectionInternal(float checkInterval, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		protected override bool Init(TimeCheatingDetector instance, string detectorName)
		{
			return false;
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override bool DetectorHasListeners()
		{
			return false;
		}

		protected override void PauseDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckForCheat_003Ed__68))]
		private IEnumerator CheckForCheat()
		{
			return null;
		}

		private void ReportCheckResult()
		{
		}

		private void OnOnlineTimeReceived(OnlineTimeResult result)
		{
		}

		private double GetLocalSecondsUtc()
		{
			return 0.0;
		}

		private static int GetAndroidSDKLevel()
		{
			return 0;
		}

		[Obsolete("Please use GetOnlineTimeCoroutine or GetOnlineTimeTask instead", true)]
		public static double GetOnlineTime(string server)
		{
			return 0.0;
		}

		[Obsolete("Please use Instance.Error event instead.", true)]
		public static void SetErrorCallback(Action<ErrorKind> errorCallback)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, int interval)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, Action<ErrorKind> errorCallback, int interval)
		{
		}

		[Obsolete("Please use other overloads of this method instead", true)]
		public static void StartDetection(float interval, Action detectionCallback, Action<ErrorKind> errorCallback, Action checkPassedCallback)
		{
		}

		public TimeCheatingDetector()
		{
			((ACTkDetectorBase<>)(object)this)._002Ector();
		}
	}
}
