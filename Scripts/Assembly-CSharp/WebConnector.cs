using System;
using System.Collections.Generic;
using UnityEngine;

public class WebConnector : MonoBehaviour
{
	public enum eType
	{
		normal = 0,
		mission = 1,
		achievement = 2,
		monitor = 3,
		battle = 4,
		asyncLevel = 5,
		size = 6
	}

	public static NetSimulator _netSimulator;

	public const int CHECK_NET_LANG_ID = 46050;

	public const int FAILED_NET_LANG_ID = 46051;

	public const int MAINTERNANCE_LANG_ID = 46049;

	public const int BLOCKED_USER_LANG_ID = 46054;

	public const int CHECK_VERSION_LANG_ID = 46052;

	public const int CHECK_REQUESTKEY_KICK_LANG_ID = 46150;

	public const int CHECK_REQUESTKEY_DEVICE_LANG_ID = 46149;

	public static WebConnector[] _Instances;

	public static string _requestKey;

	public accountPermission.eType _accountPermission;

	public static bool _HTTPS;

	public static string _defaultURL;

	public static string _pingURL;

	public static CheckNet _checkNet;

	public static pingChecker _pingChecker;

	public static bool _doCompress;

	public static bool _doEncrypt;

	private bool _isActive;

	public static long _isRetry;

	public List<WWWLoader> _WWWLoader;

	private bool _isLock;

	private WebFormat _currentFormat;

	private Queue<WebFormat> _requestQueue;

	public static bool _isNetworkError;

	public static WebConnector Instance => null;

	public static WebConnector GetInstance(eType type = eType.normal)
	{
		return null;
	}

	public static bool IsActive()
	{
		return false;
	}

	private void Update()
	{
	}

	private void EndCheckNet(bool isResult)
	{
	}

	private void Awake()
	{
	}

	public void AttachPingChecker()
	{
	}

	public static void setConnectInfo(bool https, string IP, int port)
	{
	}

	public static void setConnectPingInfo(string IP, int port)
	{
	}

	public void Check(CheckNet.AvailableCallBack callBack, bool bIndicator = false, bool bMsgBox = false, short retryCount = 2)
	{
	}

	public T Add<T>() where T : WWWData
	{
		return null;
	}

	public T Get<T>() where T : WWWData
	{
		return null;
	}

	private void Request()
	{
	}

	public static WebFormat CreateWebFormat(string url, ReqParam request, short tryCount = 3, bool checkRecv = true)
	{
		return null;
	}

	public static string getConnectURL(ReqParam request, string contensURL)
	{
		return null;
	}

	public void SetLock(bool isLock)
	{
	}

	public void Request(WebFormat data)
	{
	}

	private void callBack(WebFormat data, bool wwwResult, string response)
	{
	}

	public static void OnError(string msg, string strErrCode = "")
	{
	}

	private static void OnErrorCallBack(GameObject obj, UIButton btn)
	{
	}

	private void Clear()
	{
	}

	public static void Start()
	{
	}

	public static void Stop()
	{
	}

	private static void SetState(bool bState)
	{
	}

	public void Login()
	{
	}

	public void Connect()
	{
	}

	public static bool GetClearState()
	{
		return false;
	}

	public bool RemoveQueue(WWWData www)
	{
		return false;
	}

	public bool RemoveQueue(Type type)
	{
		return false;
	}
}
