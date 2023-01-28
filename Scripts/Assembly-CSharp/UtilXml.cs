using System;
using System.Collections.Generic;
using System.Xml;

public class UtilXml
{
	public static bool IsComment(XmlNode node)
	{
		return false;
	}

	public static bool HasAttribute(XmlNode node, string attrName)
	{
		return false;
	}

	public static string GetAttrVal_S(XmlNode node, string attrName)
	{
		return null;
	}

	public static string[] GetAttrVal_S_Split(XmlNode node, string attrName)
	{
		return null;
	}

	public static bool GetAttrVal_S(XmlNode node, string attrName, out string sAttrValue)
	{
		sAttrValue = null;
		return false;
	}

	public static int GetAttrVal_I(XmlNode node, string attrName, int defaultValue = 0)
	{
		return 0;
	}

	public static bool GetAttrVal_I(XmlNode node, string attrName, out int nAttrValue, int defaultValue = 0)
	{
		nAttrValue = default(int);
		return false;
	}

	public static long GetAttrVal_L(XmlNode node, string attrName)
	{
		return 0L;
	}

	public static bool GetAttrVal_L(XmlNode node, string attrName, out long nAttrValue)
	{
		nAttrValue = default(long);
		return false;
	}

	public static float GetAttrVal_F(XmlNode node, string attrName)
	{
		return 0f;
	}

	public static bool GetAttrVal_F(XmlNode node, string attrName, out float fAttrValue)
	{
		fAttrValue = default(float);
		return false;
	}

	public static double GetAttrVal_D(XmlNode node, string attrName)
	{
		return 0.0;
	}

	public static bool GetAttrVal_D(XmlNode node, string attrName, out double dAttrValue)
	{
		dAttrValue = default(double);
		return false;
	}

	public static decimal GetAttrVal_Dm(XmlNode node, string attrName)
	{
		return default(decimal);
	}

	public static bool GetAttrVal_Dm(XmlNode node, string attrName, out decimal dAttrValue)
	{
		dAttrValue = default(decimal);
		return false;
	}

	public static DateTime GetAttrVal_DateTime(XmlNode node, string attrName, DateTime defaultVal)
	{
		return default(DateTime);
	}

	public static DateTime GetAttrVal_DateTime(string value, DateTime defaultVal)
	{
		return default(DateTime);
	}

	public static DateHour GetAttrVal_DateHour(XmlNode node, string attrName, DateHour defaultVal)
	{
		return null;
	}

	public static DateHour GetAttrVal_DateHour(string value, DateHour defaultVal)
	{
		return null;
	}

	public static void GetSplitList(XmlNode node, string attrName, List<decimal> targetList)
	{
	}

	public static void GetSplitList(XmlNode node, string attrName, List<string> targetList)
	{
	}

	public static List<T> GetSplitList<T>(XmlNode node, string attrName)
	{
		return null;
	}

	public static List<DateTime> GetSplitList(XmlNode node, string attrName, DateTime defaultVal)
	{
		return null;
	}

	public static List<DateHour> GetSplitList(XmlNode node, string attrName, DateHour defaultVal)
	{
		return null;
	}

	public static List<DateTime> GetSplitList(string strList, DateTime defaultVal)
	{
		return null;
	}

	public static List<DateHour> GetSplitList(string strList, DateHour defaultVal)
	{
		return null;
	}

	public static void GetSplitList(XmlNode node, string type, string condition, string value, List<ContentsFunctionData> targetList)
	{
	}

	public static void GetSplitList(XmlNode node, string type, string condition, string value, string value2, List<ContentsFunctionData> targetList)
	{
	}

	public static void LoadData(SpriteData data, XmlNode node, string folder, string atlas, string image)
	{
	}

	public static XmlAttribute SetAttr_S(XmlDocument xdoc, XmlElement xeParent, string attrName, string sAttrValue)
	{
		return null;
	}

	public static XmlAttribute SetAttr_I(XmlDocument xdoc, XmlElement xeParent, string attrName, int nAttrValue)
	{
		return null;
	}

	public static XmlAttribute SetAttr_F(XmlDocument xdoc, XmlElement xeParent, string attrName, float fAttrValue)
	{
		return null;
	}

	public static XmlAttribute SetAttr_D(XmlDocument xdoc, XmlElement xeParent, string attrName, double dAttrValue)
	{
		return null;
	}

	public static string ByteArrayToUtf8String(byte[] byteArray)
	{
		return null;
	}

	public static string Utf8ToUnicodeString(string utf8String)
	{
		return null;
	}
}
