using System;
using System.Collections.Generic;
using UnityEngine;

public class TableLoader
{
	public enum eSourceType
	{
		XML = 0,
		Prefab = 1
	}

	public static void Load(eSourceType sourceType, string folderPath, Dictionary<Type, TableBase> dic)
	{
	}

	public static void LoadPrefab(Dictionary<Type, TableBase> dic, GameObject prefab)
	{
	}

	public static void LoadTextAsset(Dictionary<Type, TableBase> dic, TextAsset textAsset, string fileName)
	{
	}

	public static void LoadXML(Dictionary<Type, TableBase> dic, string folderPath, string fileName)
	{
	}

	public static bool IsDeploy()
	{
		return false;
	}
}
