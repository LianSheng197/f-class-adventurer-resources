using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShopPopupCategory")]
public class DesignShopPopupCategory : DesignShopCategory
{
	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override List<Data> GetDesign()
	{
		return null;
	}

	public override bool IsGetActiveShopPopupButton(Data cat)
	{
		return false;
	}
}
