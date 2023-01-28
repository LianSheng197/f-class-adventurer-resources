using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class TableBase : MonoBehaviour
{
	public void LoadXml(XmlDocument doc)
	{
	}

	public virtual void ClearData()
	{
	}

	public virtual void LoadXml(XmlNodeList nodeList)
	{
	}

	public virtual void CalcData()
	{
	}

	public virtual void GlobalCalcData()
	{
	}

	protected void GetSplitList(XmlNode node, string attrName, List<decimal> targetList)
	{
	}

	protected void GetSplitList(XmlNode node, string attrName, List<string> targetList)
	{
	}

	protected List<T> GetSplitList<T>(XmlNode node, string attrName)
	{
		return null;
	}

	protected List<DateTime> GetSplitList(XmlNode node, string attrName, DateTime defaultVal)
	{
		return null;
	}

	protected List<DateHour> GetSplitList(XmlNode node, string attrName, DateHour defaultVal)
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

	protected void LoadData(SpriteData data, XmlNode node, string folder, string atlas, string image)
	{
	}

	protected void LoadData(PrefabData data, XmlNode node, string folder, string prefab)
	{
	}

	protected void LoadData(TextureData data, XmlNode node, string folder, string texture)
	{
	}

	protected void LoadData(ResourceData data, XmlNode node, string folder, string skeletonData, string scale, string uiScale)
	{
	}

	protected void GetSplitList(XmlNode node, string type, string condition, List<ContentsFunctionData> targetList)
	{
	}

	protected void GetSplitList(XmlNode node, string type, string condition, string value, List<ContentsFunctionData> targetList)
	{
	}

	protected void GetSplitList(XmlNode node, string type, string condition, string value, string value2, List<ContentsFunctionData> targetList)
	{
	}

	protected Color GetColor(XmlNode node, string color)
	{
		return default(Color);
	}
}
