using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignActor")]
public class DesignActor : TableBase
{
	[Serializable]
	public class Data
	{
		public enum ResourceType
		{
			Spine = 1,
			SPUM = 2,
			Sprite = 3
		}

		public int _id;

		public SpriteData _cardSprite;

		public SpriteData _miniSprite;

		public ResourceType _resourceType;

		public ResourceData _resourceData;

		public float _tombSpineScale;

		public float _boxSizeX;

		public float _boxSizeY;

		public float _offsetX;

		public float _offsetY;

		public float _effectScale;

		public float _defaultCastingTime;

		public int _arrowEffect;

		public int _arrowEffectStartingPositionX;

		public int _arrowEffectStartingPositionY;

		public int _damageEffect;

		public int _damagePositionX;

		public int _damagePositionY;

		public float _attackTimeScale;

		public float _attack2TimeScale;

		public float _attack3TimeScale;

		public float _runTimeScale;

		public int _stageMoveText;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}
}
