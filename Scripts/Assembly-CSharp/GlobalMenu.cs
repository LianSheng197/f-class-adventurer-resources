using System.Collections.Generic;
using UnityEngine;

public class GlobalMenu : MonoBehaviour
{
	private static GlobalMenu _instance;

	public UIPanel _panel;

	private int _worldId;

	private GlobalMainMenu _globalMainMenu;

	private GameObject _newEvent;

	private GameObject _newSpecialEvent;

	private UIGrid _shopBtnGrid;

	private UIGrid _eventBtnGrid;

	private GameObject _hottime;

	private UIGrid _subMenuGrid;

	private GameObject _newAdsWorld;

	private GameObject _specialMission;

	private GameObject _shopNowOnly;

	private bool _isShowAds;

	private GameObject _guideMissionObj;

	private GameObject _guideMissionTutorialObj;

	private bool _init;

	private GachaGroup _currentEventGachaGroup;

	public const float _updateUIInterval = 10f;

	public const float _updateTimeLabelInterval = 0.6f;

	private float _updageUITime;

	private BattleRecord _battleRecord;

	private List<Transform> _adsBuffList;

	private DesignShopPopupButton _designSPB;

	private GameObject _prefabSPB;

	private List<int> _idsSPB;

	private List<int> _idsSPBNew;

	private bool _isSPBFirst;

	private GameObject _objShopNowOnlyLabel;

	private float _lastUpdateTimeAdsBuff;

	private int _activeCount;

	public static GlobalMenu Instance => null;

	private void Update()
	{
	}

	public void Init(int worldId)
	{
	}

	private void Message(UIButton btn)
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}

	private void PlayAdsCallback(WWWData data)
	{
	}

	private void CallBackBattleExit(GameObject obj, UIButton btn)
	{
	}

	private void WWWResultBossExit(WWWData www)
	{
	}

	private void WWWResultGuildBossExit(WWWData www)
	{
	}

	private void WWWResultBattleStage(WWWData www)
	{
	}

	private void GotoBattleReturn()
	{
	}

	private void GotoWorldScene()
	{
	}

	private void ChangedMenu()
	{
	}

	public void UpdateUI()
	{
	}

	public void SetWorldUI()
	{
	}

	private void IsNew()
	{
	}

	public void IsNewGlobalMenu()
	{
	}

	private void IsNewPopupShop()
	{
	}

	private void IsNewEvent()
	{
	}

	private void IsNewSpecialEvent()
	{
	}

	private void IsNewSpecialMission()
	{
	}

	private void ShowSpecialMission(bool isShow)
	{
	}

	public void UpdateHotTime()
	{
	}

	public void UpdateShopPopupBtn()
	{
	}

	private void OpenPopupShop(UIButton btn)
	{
	}

	public int CheckAdsCount()
	{
		return 0;
	}

	private void AddAdsCount()
	{
	}

	public void UpdateShopNowOnly()
	{
	}

	public void UpdateMenuSelect()
	{
	}

	public void InitGuideMission()
	{
	}

	public void UpdateGuideMission()
	{
	}

	private void GuideMission(UIButton btn)
	{
	}

	public void UpdateEventWorldMap()
	{
	}

	private void InitBattleRecord()
	{
	}

	public BattleRecord GetBattleRecord()
	{
		return null;
	}

	public void UpdateClearWorld()
	{
	}

	public void UpdateAdsBuff()
	{
	}
}
