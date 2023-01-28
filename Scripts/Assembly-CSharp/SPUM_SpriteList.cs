using System.Collections.Generic;
using UnityEngine;

public class SPUM_SpriteList : MonoBehaviour
{
	public List<SpriteRenderer> _itemList;

	public List<SpriteRenderer> _eyeList;

	public List<SpriteRenderer> _hairList;

	public List<SpriteRenderer> _bodyList;

	public List<SpriteRenderer> _clothList;

	public List<SpriteRenderer> _armorList;

	public List<SpriteRenderer> _pantList;

	public List<SpriteRenderer> _weaponList;

	public List<SpriteRenderer> _backList;

	public SPUM_HorseSpriteList _spHorseSPList;

	public string _spHorseString;

	public Texture2D _bodyTexture;

	public string _bodyString;

	public List<string> _hairListString;

	public List<string> _clothListString;

	public List<string> _armorListString;

	public List<string> _pantListString;

	public List<string> _weaponListString;

	public List<string> _backListString;

	public void Reset()
	{
	}

	public void LoadSpriteSting()
	{
	}

	public void LoadSpriteStingProcess(List<SpriteRenderer> SpList, List<string> StringList)
	{
	}

	public void LoadSprite(SPUM_SpriteList data)
	{
	}

	public void SetSpriteList(List<SpriteRenderer> tList, List<SpriteRenderer> tData)
	{
	}

	public void ResyncData()
	{
	}

	public void SyncPath(List<SpriteRenderer> _objList, List<string> _pathList)
	{
	}
}
