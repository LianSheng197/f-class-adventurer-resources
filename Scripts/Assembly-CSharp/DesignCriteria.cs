using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCriteria")]
public class DesignCriteria : TableBase
{
	[Serializable]
	public class Data
	{
		public enum TYPE
		{
			None = 0,
			Lv = 1,
			Monster_Kill = 2,
			Monster_Kill_Target = 3,
			Reward_Count_Target = 4,
			Item_Use = 5,
			Ruby_Get = 6,
			Ruby_Use = 7,
			Buy_Item = 8,
			Buy_CashItem = 9,
			PlayTime = 10,
			StageIn_Target = 11,
			StageClear_Target = 12,
			WorldIn_Target = 13,
			WorldClear_Target = 14,
			Guild_Join = 15,
			Guild_Shop_In = 16,
			Gatcha_Buy = 17,
			GatchaStepUp_Buy_Target = 18,
			BattleTotalStat_NotUse = 19,
			Buy_ShopItem = 20,
			Buy_ShopCategory = 21,
			StageClear_Target2 = 22,
			Stat_LevelUp_Type = 23,
			Stat_LevelUp_Target = 24,
			Stat_Level_Target = 25,
			Stat_RandomOption = 26,
			Get_Item_Target = 27,
			Equip_LevelUp = 31,
			Equip_GradeUp = 32,
			Weapon_Grade_Count_Target = 33,
			Weapon_Grade_Level_Target = 34,
			Armor_Grade_Count_Target = 35,
			Armor_Grade_Level_Target = 36,
			Accessory_Grade_Count_Target = 37,
			Accessory_Grade_Level_Target = 38,
			Equip_Mount_Target = 39,
			Equip_Mount_Type_Target = 40,
			Equip_GradeUp_Target = 41,
			Equip_LevelUp_Target = 42,
			Artifact_Search = 43,
			Skill_Count = 51,
			Skill_LevelUp = 52,
			Skill_FameUp = 53,
			Skill_Grade_Count_Target = 54,
			Skill_LevelUp_Count_Target = 55,
			Skill_FameUp_Count_Target = 56,
			Skill_LevelUp_Target = 57,
			Skill_Amount = 58,
			Skill_Use = 59,
			Relic_Get = 61,
			Relic_LevelUp = 62,
			Relic_LevelUp_Target = 63,
			Relic_LevelUp_Count = 64,
			Collection_LevelUp = 65,
			PowerStone_LevelUp = 68,
			PowerStone_LevelUp_Count = 69,
			Skin_Count = 72,
			Skin_LevelUp = 73,
			Skin_LevelUp_Count = 74,
			Skin_LevelUp_Count_Target = 75,
			Skin_FameUp = 76,
			Skin_FameUp_Count = 77,
			Skin_FameUp_Target = 78,
			KeepMark_LevelUp = 79,
			LoginDayCount = 81,
			AccountAccept = 82,
			RankingConfirm = 83,
			OpenLounge = 84,
			OpenTrial = 85,
			Promotion_Try = 86,
			AdsBuff = 87,
			AdsShow = 88
		}

		public int _id;

		public int _description;

		public string _value;

		private Dictionary<int, string> _needArg;

		private string _replaceDescription;

		public void CalcDescription(List<string> _formatList)
		{
		}

		public int GetNeedArgCount()
		{
			return 0;
		}

		public string GetReplaceDescription()
		{
			return null;
		}

		public string GetNeedArg(int idx)
		{
			return null;
		}

		public int FindArg(string argName)
		{
			return 0;
		}

		public string ToStringArg(int idx, int designId)
		{
			return null;
		}

		public string GetValue(long value)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public List<string> GetFormatList()
	{
		return null;
	}

	public override void CalcData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public List<Data.TYPE> GetTypeList()
	{
		return null;
	}
}
