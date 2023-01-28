using System;
using System.Collections.Generic;
using UnityEngine;

public class TableManager : MonoBehaviour
{
	private static TableManager _instance;

	public bool _isLoaded;

	private Dictionary<Type, TableBase> _data;

	private static string[] _decimal36Table;

	public static TableManager Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string GetUserCode(int userId, DateTime createTime)
	{
		return null;
	}

	public static int GetUserIDFromUserCode(string userCode)
	{
		return 0;
	}

	public static string EncodeDecimal(int dec, int decimalValue)
	{
		return null;
	}

	public static int DecodeDecimal(string code, int decimalValue)
	{
		return 0;
	}

	public static int GetDecodeIndex(char value)
	{
		return 0;
	}

	public static void ClearData()
	{
	}

	public void LoadCommonData()
	{
	}

	public void LoadData()
	{
	}

	private void CalcGlobalData()
	{
	}

	public void LoadEnd()
	{
	}

	public static T Get<T>() where T : TableBase
	{
		return null;
	}

	public T GetData<T>() where T : TableBase
	{
		return null;
	}

	public static string CommonString(int id)
	{
		return null;
	}

	public static string String(int id)
	{
		return null;
	}

	public static string GetCommonKorean(int id)
	{
		return null;
	}

	public static string GetKorean(int id)
	{
		return null;
	}

	public static string GameConfig(string id)
	{
		return null;
	}

	public static T GameConfig<T>(string key, T defaultValue = default(T))
	{
		return default(T);
	}

	public static string GetContentsFunctionDesc(List<ContentsFunctionData> data)
	{
		return null;
	}

	public static string GetContentsFunctionDesc(ContentsFunctionData data)
	{
		return null;
	}

	public static string GetContentsFunctionValue(ContentsFunctionData data)
	{
		return null;
	}

	public static string GetCriteriaDesc(CriteriaData criteriaData)
	{
		return null;
	}

	public static string GetCriteriaDesc(DesignCriteria.Data data, long criteriaValue, int criteriaCondition1, int criteriaCondition2 = 0)
	{
		return null;
	}

	public string MaterialAlertMsg(Character Char)
	{
		return null;
	}

	public string MaterialAlertMsg(List<Character> list)
	{
		return null;
	}
}
