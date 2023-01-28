using System.Collections.Generic;
using UnityEngine;

public class AttachTopUI : MonoBehaviour
{
	public GameObject _topUI;

	public UIPanel _panelTopUI;

	public GameObject _menuList;

	private UILabel _name;

	private GameObject _createName;

	private UILabel _createTempName;

	private UILabel _lv;

	private UISlider _expSlider;

	private UILabel _exp;

	private UILabel _expPercent;

	private GameObject _levelUpBtn;

	private UISprite _characterIcon;

	private UILabel _battleStat;

	private UILabel _ranking;

	private UILabel _battleStatAttack;

	private UILabel _battleStatDefence;

	private UILabel _battleStatMagic;

	private GameObject _mailNew;

	private GameObject _menuNew;

	private GameObject _newAchievement;

	private GameObject _newGuild;

	private GameObject _newRank;

	private BulletEffect _fxGetCash;

	private List<AutoCurrency> _currency;

	private List<AutoCurrency> _currencyExtension;

	private UIGrid _moneyExtension;

	private double _prevBattleStat;

	private double _prevBattleStatAttack;

	private double _prevBattleStatDefence;

	private double _prevBattleStatMagic;

	private void Init()
	{
	}

	public void InitSceneTopUI()
	{
	}

	public void UpdateName()
	{
	}

	public void UpdateTeamLevel()
	{
	}

	public void UpdateCurrency()
	{
	}

	public void UpdateCharacterIcon()
	{
	}

	public void UpdateTopUI()
	{
	}

	public void UpdateNew()
	{
	}

	public bool CheckEscapeMenu()
	{
		return false;
	}

	public void SetWorldUI(int worldId)
	{
	}

	public void ScenarioObjectActive(bool isActive)
	{
	}

	private void UpdateNewMail()
	{
	}

	private bool UpdateAchievementNew()
	{
		return false;
	}

	private void UpdateMenuNew()
	{
	}

	private bool UpdateGuildNew()
	{
		return false;
	}

	private bool UpdateRankNew()
	{
		return false;
	}

	private void WWWGetStorageResult(WWWData www)
	{
	}

	private void UpdateMoneyExtension()
	{
	}

	public void HideMenuList()
	{
	}

	private void ShowMenuList(bool isShow)
	{
	}

	private void EndMenuOpen(GameObject obj)
	{
	}

	private void EndMenuEnd(GameObject obj)
	{
	}

	private void Message(UIButton btn)
	{
	}

	public void EndFxGetCash()
	{
	}

	public void ShowWorldRanking(int worldId)
	{
	}

	private void OnWorldRankingCallback(WWWData wwwData)
	{
	}

	private void RequestAsync(UIButton btn)
	{
	}

	private void LvUp(UIButton btn)
	{
	}
}
