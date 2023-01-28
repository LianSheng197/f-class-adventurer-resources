using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Event System (UICamera)")]
[RequireComponent(typeof(Camera))]
public class UICamera : MonoBehaviour
{
	[DoNotObfuscateNGUI]
	public enum ControlScheme
	{
		Mouse = 0,
		Touch = 1,
		Controller = 2
	}

	[DoNotObfuscateNGUI]
	public enum ClickNotification
	{
		None = 0,
		Always = 1,
		BasedOnDelta = 2
	}

	public class MouseOrTouch
	{
		public KeyCode key;

		public Vector2 pos;

		public Vector2 lastPos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject last;

		public GameObject current;

		public GameObject pressed;

		public GameObject dragged;

		public float pressTime;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool pressStarted;

		public bool dragStarted;

		public int ignoreDelta;

		public float deltaTime => 0f;

		public bool isOverUI => false;
	}

	[DoNotObfuscateNGUI]
	public enum EventType
	{
		World_3D = 0,
		UI_3D = 1,
		World_2D = 2,
		UI_2D = 3
	}

	public delegate bool GetKeyStateFunc(KeyCode key);

	public delegate float GetAxisFunc(string name);

	public delegate bool GetAnyKeyFunc();

	public delegate MouseOrTouch GetMouseDelegate(int button);

	public delegate MouseOrTouch GetTouchDelegate(int id, bool createIfMissing);

	public delegate void RemoveTouchDelegate(int id);

	public delegate void OnScreenResize();

	[DoNotObfuscateNGUI]
	public enum ProcessEventsIn
	{
		Update = 0,
		LateUpdate = 1
	}

	public delegate void OnCustomInput();

	public delegate void OnSchemeChange();

	public delegate void MoveDelegate(Vector2 delta);

	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	private struct DepthEntry
	{
		public int depth;

		public RaycastHit hit;

		public Vector3 point;

		public GameObject go;
	}

	public class Touch
	{
		public int fingerId;

		public TouchPhase phase;

		public Vector2 position;

		public int tapCount;
	}

	public delegate int GetTouchCountCallback();

	public delegate Touch GetTouchCallback(int index);

	public static BetterList<UICamera> list;

	public static GetKeyStateFunc GetKeyDown;

	public static GetKeyStateFunc GetKeyUp;

	public static GetKeyStateFunc GetKey;

	public static GetAxisFunc GetAxis;

	public static GetAnyKeyFunc GetAnyKeyDown;

	public static GetMouseDelegate GetMouse;

	public static GetTouchDelegate GetTouch;

	public static RemoveTouchDelegate RemoveTouch;

	public static OnScreenResize onScreenResize;

	public EventType eventType;

	public bool eventsGoToColliders;

	public LayerMask eventReceiverMask;

	public ProcessEventsIn processEventsIn;

	public bool debug;

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public bool stickyTooltip;

	public float tooltipDelay;

	public bool longPressTooltip;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string horizontalAxisName;

	public string verticalAxisName;

	public string horizontalPanAxisName;

	public string verticalPanAxisName;

	public string scrollAxisName;

	[Tooltip("If enabled, command-click will result in a right-click event on OSX")]
	public bool commandClick;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public bool autoHideCursor;

	public static OnCustomInput onCustomInput;

	public static bool showTooltips;

	public static bool ignoreAllEvents;

	public static bool ignoreControllerInput;

	private static bool mDisableController;

	private static Vector2 mLastPos;

	public static Vector3 lastWorldPosition;

	public static Ray lastWorldRay;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static OnSchemeChange onSchemeChange;

	private static ControlScheme mLastScheme;

	public static int currentTouchID;

	private static KeyCode mCurrentKey;

	public static MouseOrTouch currentTouch;

	private static bool mInputFocus;

	private static GameObject mGenericHandler;

	public static GameObject fallThrough;

	public static VoidDelegate onClick;

	public static VoidDelegate onDoubleClick;

	public static BoolDelegate onHover;

	public static BoolDelegate onPress;

	public static BoolDelegate onSelect;

	public static FloatDelegate onScroll;

	public static VectorDelegate onDrag;

	public static VoidDelegate onDragStart;

	public static ObjectDelegate onDragOver;

	public static ObjectDelegate onDragOut;

	public static VoidDelegate onDragEnd;

	public static ObjectDelegate onDrop;

	public static KeyCodeDelegate onKey;

	public static KeyCodeDelegate onNavigate;

	public static VectorDelegate onPan;

	public static BoolDelegate onTooltip;

	public static MoveDelegate onMouseMove;

	private static MouseOrTouch[] mMouse;

	public static MouseOrTouch controller;

	public static List<MouseOrTouch> activeTouches;

	private static List<int> mTouchIDs;

	private static int mWidth;

	private static int mHeight;

	private static GameObject mTooltip;

	private Camera mCam;

	private static float mTooltipTime;

	private float mNextRaycast;

	public static bool isDragging;

	private static int mLastInteractionCheck;

	private static bool mLastInteractionResult;

	private static int mLastFocusCheck;

	private static bool mLastFocusResult;

	private static int mLastOverCheck;

	private static bool mLastOverResult;

	private static GameObject mRayHitObject;

	private static GameObject mHover;

	private static GameObject mSelected;

	private static DepthEntry mHit;

	private static BetterList<DepthEntry> mHits;

	private static RaycastHit[] mRayHits;

	private static Collider2D[] mOverlap;

	private static Plane m2DPlane;

	private static float mNextEvent;

	private static int mNotifying;

	private static bool mUsingTouchEvents;

	public static GetTouchCountCallback GetInputTouchCount;

	public static GetTouchCallback GetInputTouch;

	[Obsolete("Use new OnDragStart / OnDragOver / OnDragOut / OnDragEnd events instead")]
	public bool stickyPress => false;

	public static bool disableController
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Use lastEventPosition instead. It handles controller input properly.")]
	public static Vector2 lastTouchPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public static Vector2 lastEventPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public static UICamera first => null;

	public static ControlScheme currentScheme
	{
		get
		{
			return default(ControlScheme);
		}
		set
		{
		}
	}

	public static KeyCode currentKey
	{
		get
		{
			return default(KeyCode);
		}
		set
		{
		}
	}

	public static Ray currentRay => default(Ray);

	public static bool inputHasFocus => false;

	[Obsolete("Use delegates instead such as UICamera.onClick, UICamera.onHover, etc.")]
	public static GameObject genericEventHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static MouseOrTouch mouse0 => null;

	public static MouseOrTouch mouse1 => null;

	public static MouseOrTouch mouse2 => null;

	private bool handlesEvents => false;

	public Camera cachedCamera => null;

	public static GameObject tooltipObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool isOverUI => false;

	public static bool uiHasFocus => false;

	public static bool interactingWithUI => false;

	public static GameObject hoveredObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GameObject controllerNavigationObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GameObject selectedObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use either 'CountInputSources()' or 'activeTouches.Count'")]
	public static int touchCount => 0;

	public static int dragCount => 0;

	public static Camera mainCamera => null;

	public static UICamera eventHandler => null;

	public static bool IsPartOfUI(GameObject go)
	{
		return false;
	}

	public static bool IsPressed(GameObject go)
	{
		return false;
	}

	public static int CountInputSources()
	{
		return 0;
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		return 0;
	}

	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		return null;
	}

	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		return null;
	}

	public static void Raycast(MouseOrTouch touch)
	{
	}

	public static bool Raycast(Vector3 inPos)
	{
		return false;
	}

	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		return false;
	}

	private static bool IsVisible(ref DepthEntry de)
	{
		return false;
	}

	public static bool IsHighlighted(GameObject go)
	{
		return false;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return 0;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return 0;
	}

	private static int GetDirection(string axis)
	{
		return 0;
	}

	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Start ignoring events")]
	private void StartIgnoring()
	{
	}

	[ContextMenu("Stop ignoring events")]
	private void StopIgnoring()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void ProcessEvents()
	{
	}

	public void ProcessMouse()
	{
	}

	public void ProcessTouches()
	{
	}

	private void ProcessFakeTouches()
	{
	}

	public void ProcessOthers()
	{
	}

	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	private bool HasCollider(GameObject go)
	{
		return false;
	}

	public void ProcessTouch(bool pressed, bool released)
	{
	}

	public static void CancelNextTooltip()
	{
	}

	public static bool ShowTooltip(GameObject go)
	{
		return false;
	}

	public static bool HideTooltip()
	{
		return false;
	}

	public static void ResetTooltip(float delay = 0.5f)
	{
	}
}
