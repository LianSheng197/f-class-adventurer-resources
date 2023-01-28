using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	[DisallowMultipleComponent]
	[HelpURL("https://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
	public class WallHackDetector : ACTkDetectorBase<WallHackDetector>
	{
		[CompilerGenerated]
		private sealed class _003CInitDetector_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

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
			public _003CInitDetector_003Ed__71(int _003C_003E1__state)
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
		private sealed class _003CCaptureFrame_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

			private RenderTexture _003CpreviousActive_003E5__2;

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
			public _003CCaptureFrame_003Ed__76(int _003C_003E1__state)
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

		public const string ComponentName = "WallHack Detector";

		internal const string LogPrefix = "[ACTk] WallHack Detector: ";

		internal const string WireframeShaderName = "Hidden/ACTk/WallHackTexture";

		private const string ServiceContainerName = "[WH Detector Service]";

		private const int ShaderTextureSize = 4;

		private const int RenderTextureSize = 4;

		private const int ColorsDifferenceThreshold = 5;

		private readonly Vector3 rigidPlayerVelocity;

		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		private bool checkRigidbody;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		private bool checkController;

		[SerializeField]
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		private bool checkWireframe;

		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		[SerializeField]
		private bool checkRaycast;

		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int wireframeDelay;

		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int raycastDelay;

		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives;

		private GameObject serviceContainer;

		private GameObject solidWall;

		private GameObject thinWall;

		private Camera wfCamera;

		private MeshRenderer foregroundRenderer;

		private MeshRenderer backgroundRenderer;

		private Color wfColor1;

		private Color wfColor2;

		private Shader wfShader;

		private Material wfMaterial;

		private Texture2D shaderTexture;

		private Texture2D targetTexture;

		private RenderTexture renderTexture;

		private int whLayer;

		private int raycastMask;

		private Rigidbody rigidPlayer;

		private CharacterController charControllerPlayer;

		private float charControllerVelocity;

		private byte rigidbodyDetections;

		private byte controllerDetections;

		private byte wireframeDetections;

		private byte raycastDetections;

		private bool wireframeDetected;

		private readonly RaycastHit[] rayHits;

		public bool CheckRigidbody
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckWireframe
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckRaycast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static WallHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static WallHackDetector StartDetection()
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback)
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition)
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private WallHackDetector()
		{
			((ACTkDetectorBase<>)(object)this)._002Ector();
		}

		protected override void OnDestroy()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private WallHackDetector StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
			return null;
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override bool ResumeDetector()
		{
			return false;
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private void UpdateServiceContainer()
		{
		}

		[IteratorStateMachine(typeof(_003CInitDetector_003Ed__71))]
		private IEnumerator InitDetector()
		{
			return null;
		}

		private void StartRigidModule()
		{
		}

		private void StartControllerModule()
		{
		}

		private void StartWireframeModule()
		{
		}

		private void ShootWireframeModule()
		{
		}

		[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__76))]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		private bool ColorsDiffer(Color a, Color b)
		{
			return false;
		}

		private void StartRaycastModule()
		{
		}

		private void ShootRaycastModule()
		{
		}

		private void StopRigidModule()
		{
		}

		private void StopControllerModule()
		{
		}

		private void StopWireframeModule()
		{
		}

		private void StopRaycastModule()
		{
		}

		private void InitRigidModule()
		{
		}

		private void InitControllerModule()
		{
		}

		private void UninitRigidModule()
		{
		}

		private void UninitControllerModule()
		{
		}

		private bool Detect()
		{
			return false;
		}

		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return false;
		}
	}
}
