using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillEffect")]
public class DesignSkillEffect : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Location
		{
			Target = 0,
			BattleZone = 1,
			Screen = 2,
			BattleZoneViewCenter = 3,
			BattleZoneOffset = 4,
			BattleZoneOffsetFlip = 5
		}

		public enum Position
		{
			Normal = 0,
			Ground = 1
		}

		public int _id;

		public PrefabData _prefabData;

		public PrefabData _prefabData2;

		public Location _location;

		public Position _position;

		public bool _scale;

		public bool _soundOverlap;

		public string _soundFolder;

		public string _soundName;

		public int _arrowSpeed;

		public int _arrowHeight;

		public float _shaking;

		public float _screenShaking;

		public string _screenShakingAni;

		public bool _noRotation;

		public bool _arrowGround;

		public float _destroyTime;

		public Color _color;
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
