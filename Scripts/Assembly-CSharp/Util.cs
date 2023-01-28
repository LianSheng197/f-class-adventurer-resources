using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using MathNet.Numerics.Random;
using UnityEngine;

public class Util
{
	private class Seed
	{
		public int _minValue;

		public int _maxValue;
	}

	public const int _buildNumberInitialValue = 100010;

	private const byte _RankStartHour = 1;

	private const byte _RankEndHour = 3;

	private static readonly System.Random _global;

	private static readonly object LockObject;

	[ThreadStatic]
	private static System.Random _local;

	public static string clipboard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static System.Random Local => null;

	private static AndroidJavaObject GetPackageInfo()
	{
		return null;
	}

	public static int GetIOSBuildNumber()
	{
		return 0;
	}

	public static int GetAndroidVersionCode()
	{
		return 0;
	}

	public static int GetCurrentBuildNumber()
	{
		return 0;
	}

	public static int GetBuildNumber()
	{
		return 0;
	}

	public static string GetVersion()
	{
		return null;
	}

	public static string GetVersionNumber()
	{
		return null;
	}

	public static string GetUnityVersion()
	{
		return null;
	}

	public static void GameQuit()
	{
	}

	public static Transform FindChildRecursive(Transform form, string name)
	{
		return null;
	}

	public static void ChangeLayerRecursive(GameObject obj, string layerName)
	{
	}

	public static void ActiveChild(Transform form, bool active)
	{
	}

	public static EventDelegate.Parameter MakeParameter(UnityEngine.Object _value, Type _type)
	{
		return null;
	}

	public static float GetAngleVector2(Vector2 my, Vector2 target)
	{
		return 0f;
	}

	public static float GetAngleVector3(Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	private bool IsInAngle(Transform obj, Transform target, float fAngle)
	{
		return false;
	}

	public static int GetThreadId()
	{
		return 0;
	}

	public static string ProjectBasePath(string RelativePathName)
	{
		return null;
	}

	public static string GetFilePath(string filePathName)
	{
		return null;
	}

	public static string GetFileName(string filePathName)
	{
		return null;
	}

	public static string GetFileExt(string filePathName)
	{
		return null;
	}

	public static string GetPureFileName(string filePathName)
	{
		return null;
	}

	public static string ToBinString(int value, int strLength)
	{
		return null;
	}

	public static string ToBinString(int value, int strLength, char zeroChar, int sepGap, string sepStr)
	{
		return null;
	}

	public static T FindEnumValue<T>(string str)
	{
		return default(T);
	}

	public static int GetEnumCount(Type enumType)
	{
		return 0;
	}

	public static float CalcPercent(float fCur, float fTotal)
	{
		return 0f;
	}

	public static float CalcPercent(int nCur, int nTotal)
	{
		return 0f;
	}

	public static int GetTickCount()
	{
		return 0;
	}

	public static float GetElapsedTickTime(int tickTime_Start, int tickTime_End)
	{
		return 0f;
	}

	public static MeshCollider FindMeshCollider(GameObject gameobject, string meshColliderName)
	{
		return null;
	}

	public static void ShowSystemMouse(bool bShow)
	{
	}

	public static bool IsMouseCursorPlatform()
	{
		return false;
	}

	public static void setChildColor(Transform obj, Color color)
	{
	}

	public static Color GetColor(float r, float g, float b)
	{
		return default(Color);
	}

	public static Color GetColor(float r, float g, float b, float a)
	{
		return default(Color);
	}

	public static void ChangeChildColor(GameObject parentObj, Color color)
	{
	}

	public static void ChangeSpriteColor(GameObject obj, Color color)
	{
	}

	public static void ChangeSpriteColor(Transform form, Color color)
	{
	}

	public static void SetDisableButton(GameObject gameobj)
	{
	}

	public static float GetAlpha(float a)
	{
		return 0f;
	}

	public static int GetBitToInt(int nIndex)
	{
		return 0;
	}

	public static bool GetIntToBit(int nBits, int nIndex)
	{
		return false;
	}

	public static void RemoveScript<T>(GameObject target) where T : MonoBehaviour
	{
	}

	public static void RemoveChild(Transform form)
	{
	}

	public static string EscapeURL(string str)
	{
		return null;
	}

	public static void OpenEmail(string strAddress, string strSubject, string strBody)
	{
	}

	public static void MoveScrollView(UIScrollView scroll, Transform form, bool ignoreCalculateConstrain = false, bool isSpring = true)
	{
	}

	public static void MoveScrollView(UIScrollView scroll, Vector3 before, Vector3 move, bool ignoreCalculateConstrain = false, bool isSpring = true)
	{
	}

	public static void MoveScrollItem(ScrollItem scroll, Transform form, bool ignoreCalculateConstrain = false, bool isSpring = true)
	{
	}

	public static void MoveScrollItem(ScrollItem scroll, Vector3 before, Vector3 move, bool ignoreCalculateConstrain = false, bool isSpring = true)
	{
	}

	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	public static bool IsTablet()
	{
		return false;
	}

	public static bool SafeDestroy(ref GameObject obj)
	{
		return false;
	}

	public static long gettimeof64bit()
	{
		return 0L;
	}

	public static double gettimeof64bit(DateTime time)
	{
		return 0.0;
	}

	public static DateTime gettimeof64bit(double time)
	{
		return default(DateTime);
	}

	public static int getyearmonthday()
	{
		return 0;
	}

	public static int getyearmonthday(DateTime time)
	{
		return 0;
	}

	public static int getyearmonth()
	{
		return 0;
	}

	public static int getyearmonth(DateTime time)
	{
		return 0;
	}

	public static int getweekofyear()
	{
		return 0;
	}

	public static int getweekofyear(int hour, int dayOfWeek)
	{
		return 0;
	}

	public static int getweekofyear(DateTime time, int hour, int dayOfWeek)
	{
		return 0;
	}

	public static int getweekofyear(DateTime time)
	{
		return 0;
	}

	public static int getnextweekofyear()
	{
		return 0;
	}

	public static int getnextweekofyear(int hour)
	{
		return 0;
	}

	public static int getprevweekofyear()
	{
		return 0;
	}

	public static int getprevweekofyear(int weekOfYear)
	{
		return 0;
	}

	public static int getmonthofyear()
	{
		return 0;
	}

	public static int getmonthofyear(DateTime time)
	{
		return 0;
	}

	public static DateTime gettimeoftruncate(DateTime time, int hour)
	{
		return default(DateTime);
	}

	public static DateTime GetCurrentWeekDay(DayOfWeek dayOfWeek)
	{
		return default(DateTime);
	}

	public static DateTime GetCurrentWeekDay(DateTime now, DayOfWeek dayOfWeek)
	{
		return default(DateTime);
	}

	public static DateTime GetCurrentTime()
	{
		return default(DateTime);
	}

	public static DateTime SetLocalTime(DateTime time)
	{
		return default(DateTime);
	}

	public static string gettimestamp()
	{
		return null;
	}

	public static bool isRankCalcTime(DateTime pvpEnd)
	{
		return false;
	}

	public static bool isRefreshRankTime(DateTime pvpEnd, ref DateTime refreshTime)
	{
		return false;
	}

	public static TimeSpan getCountPerDayTime(DateTime lastUpdateTime, int apCount, ref int upCount, ref DateTime afterLastUpdateTime)
	{
		return default(TimeSpan);
	}

	public static int GetEventTime(long eventTime)
	{
		return 0;
	}

	public static DateTime GetCurrentDay()
	{
		return default(DateTime);
	}

	public static DateTime GetCurrentDay(DateTime curTime)
	{
		return default(DateTime);
	}

	public static DateTime GetNextDay(int day)
	{
		return default(DateTime);
	}

	public static int FindDayOfWeekDay(DayOfWeek find)
	{
		return 0;
	}

	public static void GetSplitList(string str, List<short> targetList)
	{
	}

	public static void GetSplitList(string str, List<int> targetList)
	{
	}

	public static void GetSplitList(string str, List<long> targetList)
	{
	}

	public static void GetSplitList(string str, List<float> targetList)
	{
	}

	public static void GetSplitList(string str, List<decimal> targetList)
	{
	}

	public static void GetSplitList(string str, List<string> targetList)
	{
	}

	public static List<T> GetSplitList<T>(string str)
	{
		return null;
	}

	public static int Next()
	{
		return 0;
	}

	public static int Next(int maxValue)
	{
		return 0;
	}

	public static decimal NextDecimal()
	{
		return default(decimal);
	}

	public static int RandomSeed()
	{
		return 0;
	}

	public static int Next(int minValue, int maxValue)
	{
		return 0;
	}

	public static System.Random GetRandom()
	{
		return null;
	}

	public static int Next(ref Xorshift randomFunc, int maxValue)
	{
		return 0;
	}

	public static string sha256_hash(string value)
	{
		return null;
	}

	public static int getRandomSeedValue(List<int> dataList)
	{
		return 0;
	}

	public static int getdoubletoint(double _value)
	{
		return 0;
	}

	public static int getdoubletoint(float _value)
	{
		return 0;
	}

	public static bool isBit(byte value, int pos)
	{
		return false;
	}

	public static bool isBit(int value, int pos)
	{
		return false;
	}

	public static byte setBit(byte value, int pos)
	{
		return 0;
	}

	public static int setBit(int value, int pos)
	{
		return 0;
	}

	public static byte resetBit(byte value, int pos)
	{
		return 0;
	}

	public static int resetBit(int value, int pos)
	{
		return 0;
	}

	public static decimal? ToNullableDecimal(object val)
	{
		return null;
	}

	public static string DateTimeToString(DateTime time, string format = "")
	{
		return null;
	}

	public static bool StringToDateTime(string strTime, ref DateTime result)
	{
		return false;
	}

	public static bool IsNetworkOnline()
	{
		return false;
	}

	public static float GetiOSVersion()
	{
		return 0f;
	}

	public static string GarbageFreeString(StringBuilder sb)
	{
		return null;
	}

	public static int GetSizeOfObject(object obj, int avgStringSize = -1)
	{
		return 0;
	}

	public static void GetBigIntegerToLongLong(BigInteger number, out long firstNumber, out long multiple)
	{
		firstNumber = default(long);
		multiple = default(long);
	}

	public static void GetBigIntegerToLongLong(decimal number, out long firstNumber, out long multiple)
	{
		firstNumber = default(long);
		multiple = default(long);
	}

	public static void GetBigIntegerToLongLong(double number, out long firstNumber, out long multiple)
	{
		firstNumber = default(long);
		multiple = default(long);
	}

	public static string GetName<T>(T item) where T : class
	{
		return null;
	}

	public static string GetName1<T>(T item) where T : class
	{
		return null;
	}

	public static string GetName2<T>(T item) where T : class
	{
		return null;
	}

	public static Bounds CalculateSpriteRendererBounds(Transform form)
	{
		return default(Bounds);
	}

	public static void CalculateSpriteRendererBounds(Transform form, ref Bounds b)
	{
	}
}
