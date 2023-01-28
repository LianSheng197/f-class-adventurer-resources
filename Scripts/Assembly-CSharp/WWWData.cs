using System;
using System.Collections.Generic;
using UnityEngine;

public class WWWData : MonoBehaviour, IDisposable
{
	public enum STATE
	{
		STATE_ERROR = 0,
		STATE_SUCCESS = 1,
		STATE_CHANGE_SCENE = 2,
		STATE_IGNORE_ACK = 3,
		STATE_IGNORE_ACK_INSTANCE_MSG = 4,
		STATE_IGNORE_ACK_MSG_BOX = 5,
		STATE_NOT_SYNC = 6,
		STATE_CHECK_BLOCK = 7,
		STATE_WARNING_QUERY_INJECTION = 8,
		STATE_INVALID_REQUEST_KEY = 9,
		STATE_INVALID_CLIENT_FOCED_VERSION = 10,
		STATE_INVALID_XML_VERSION = 11,
		STATE_INVALID_CLIENT_MAJOR_VERSION = 12,
		STATE_INVALID_CLIENT_MIDDLE_VERSION = 13,
		STATE_INVALID_CLIENT_MINOR_VERSION = 14,
		STATE_NOT_HAVE_PERMISSION = 15,
		STATE_ALREADY_PLATFORM_INTEGRATION = 16,
		STATE_ALREADY_PLATFORM_INTEGRATION_SELF = 17,
		STATE_USERNAME_EXIST = 18,
		STATE_USERNAME_PROHIBITION = 19,
		STATE_USERNAME_IMPOSSIBLE_LENGTH = 20,
		STATE_USERNAME_IMPOSSIBLE = 21,
		STATE_CUBE_REFRESH = 22,
		STATE_TIME_INTERVAL_ABNORMAL = 23,
		STATE_EVENT_BUFF_NOT_SYNC = 24,
		STATE_INVALID_TIME_NOT_YET = 25,
		STATE_REQUIRED_TIME_SYNC = 26,
		STATE_NOT_ENOUGH = 27,
		STATE_ALL_CHARACTER_MAGICS_LOCKED = 28,
		STATE_NO_CHARACTER_MAGICS = 29,
		STATE_WRONG_CHARACTER_MAGIC_POSITION_NO = 30,
		STATE_NO_SKINS = 31,
		STATE_SKIN_ALREADY_MAX_LEVEL = 32,
		STATE_NO_USER_NAME = 33,
		STATE_GUILD_LESS_THAN_MIN_LEVEL = 34,
		STATE_GUILD_WRONG_NAME_LENGTH = 35,
		STATE_GUILD_UNAVAILABLE_NAME = 36,
		STATE_GUILD_DUPLICATED_NAME = 37,
		STATE_GUILD_ALREADY_JOINED = 38,
		STATE_GUILD_JOINING_TIME_LIMIT_REMAINED = 39,
		STATE_GUILD_NOT_EXIST = 40,
		STATE_GUILD_ALREADY_APPLIED = 41,
		STATE_GUILD_EXCEEDING_CAPACITY = 42,
		STATE_GUILD_EXCEEDING_APPLICANT_CAPACITY = 43,
		STATE_GUILD_NOT_MEMBER = 44,
		STATE_GUILD_WRONG_ROLE = 45,
		STATE_GUILD_APPLICANT_ALREADY_JOINED = 46,
		STATE_GUILD_MASTER_CANNOT_LEAVE = 47,
		STATE_GUILD_NOT_MASTER = 48,
		STATE_GUILD_MEMBER_REMAINED = 49,
		STATE_GUILD_WRONG_INTRODUCTION_LENGTH = 50,
		STATE_GUILD_WRONG_NOTICE_LENGTH = 51,
		STATE_GUILD_CANNOT_CHANGE_MY_ROLE = 52,
		STATE_GUILD_CANNOT_FIRE_MYSELF = 53,
		STATE_GUILD_CANNOT_TRANSFER_MASTER_TO_MYSELF = 54,
		STATE_GUILD_ALREADY_ATTENDED = 55,
		STATE_GUILD_LESS_THAN_MIN_BATTLE_POINT = 56,
		STATE_GUILD_RANKING_NOT_STARTED = 57,
		STATE_GUILD_NO_BOSS_BATTLE_RECORD = 58,
		STATE_GUILD_BOSS_SWEEP_HIGH_STAGE_ONLY = 59,
		STATE_GUILD_ALREADY_RECEIVED_BOSS_DAILY_REWARD = 60,
		STATE_BOSS_BATTLE_SHOULD_CLEAR_PREVIOUS_STAGE_FIRST = 61,
		STATE_BOSS_BATTLE_SHOULD_CLEAR_STAGE_FIRST_TO_SWEEP = 62,
		STATE_COUPON_INVALID_CODE = 63,
		STATE_COUPON_ALREADY_USED = 64,
		STATE_COUPON_INVALID_PLATFORM = 65,
		STATE_COUPON_GROUP_ALREADY_USED = 66,
		STATE_GUILD_BOSS_RANKING_NO_PREV_RECORD = 67,
		STATE_GUILD_BOSS_RANKING_ALREADY_RECEIVED_PREV_RANKING_REWARD = 68,
		STATE_INVALID_REQUEST_KEY_KICK = 69,
		STATE_INVALID_REQUEST_KEY_DEVICE = 70,
		STATE_SIZE = 71
	}

	public delegate void AckCallBack(WWWData ack);

	public static GameObject _objWaiting;

	public static GameObject _shopWaitingObj;

	public static GameObject _adsWaitingObj;

	protected string _path;

	protected WebFormat _webFormat;

	public AckCallBack _callBack;

	public WWWLoader _loader;

	public bool _async;

	public bool _isPost;

	private object _reqParam;

	private object _ackParam;

	private List<UIButton> _reqButton;

	private string _res;

	private bool _IsReq;

	private static GameObject _prefab;

	private static GameObject _prefabWait;

	private void Awake()
	{
	}

	protected virtual void init()
	{
	}

	public void Dispose()
	{
	}

	public WebFormat getFormat()
	{
		return null;
	}

	public virtual bool Correction()
	{
		return false;
	}

	public T GetReq<T>() where T : ReqParam, new()
	{
		return null;
	}

	public T GetAck<T>() where T : AckParam, new()
	{
		return null;
	}

	public virtual void Req(UIButton btn)
	{
	}

	public virtual void Req()
	{
	}

	public bool Result(bool wwwResult, string response, out STATE out_Reason)
	{
		out_Reason = default(STATE);
		return false;
	}

	protected virtual bool GetAckState(AckParam ack)
	{
		return false;
	}

	private void MoveTitle(GameObject obj, UIButton btn)
	{
	}

	protected virtual AckParam Ack()
	{
		return null;
	}

	protected virtual void OnFailed()
	{
	}

	public void BtnLock(UIButton btn)
	{
	}

	public void BtnUnLock()
	{
	}

	public virtual bool isIndicator()
	{
		return false;
	}

	public static bool IsIndicator()
	{
		return false;
	}

	public static GameObject GetPrefabIndicator()
	{
		return null;
	}

	public static GameObject GetPrefabIndicatorWait()
	{
		return null;
	}

	public void invokeCreateIndicator()
	{
	}

	public void createIndicator(bool isImmediately = true)
	{
	}

	public void removeIndicator()
	{
	}

	public static void createStaticIndicator()
	{
	}

	public static void removeStaticIndicator()
	{
	}

	public static void createShopIndicator()
	{
	}

	public static void removeShopIndicator()
	{
	}

	public static void createAdsIndicator()
	{
	}

	public static void removeAdsIndicator()
	{
	}
}
