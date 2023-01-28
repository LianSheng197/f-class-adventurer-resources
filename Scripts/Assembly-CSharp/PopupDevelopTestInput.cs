using UnityEngine;

[AddComponentMenu("Popup/PopupDevelopTestInput")]
public class PopupDevelopTestInput : PopupBase
{
	public enum InputType
	{
		None = 0,
		GuestLogin = 1,
		GuestLoginLocal = 2,
		AddItem = 3,
		AddChar = 4,
		SetTeamLevelExp = 5,
		AddTeamLevelExp = 6,
		SetTeamLevel = 7,
		ClearStage = 8,
		ResetStage = 9,
		UpgradeLevel = 10,
		TutorialReset = 11,
		AddStorage = 12,
		MissionReset = 13,
		MissionClear = 14,
		PowerStoneLevel = 15,
		AchievementReset = 16,
		SetEquipmentLevel = 17,
		SetLegendLevel = 18,
		OfflineReward = 19,
		GotoGuideMission = 20,
		GotoUpdateGuideMission = 21,
		ScenarioReset = 22,
		IapTest = 23,
		SetSkill = 24,
		SetCharacteristic = 25,
		CopyUser = 26,
		AddTreasure = 27,
		RelicLevel = 28,
		AddAdsBuffExp = 29,
		SetKeepMark = 30
	}

	private InputType _inputType;

	private UIInput _input;

	private UIInput _count;

	private GameObject _inputSet;

	private UIInput _input1;

	private UIInput _input2;

	private UIInput _input3;

	private UIInput _input4;

	private UIInput _input5;

	private UIInput _input6;

	private UIInput _input7;

	private UIInput _input8;

	private UIInput _input9;

	public void InitPopup(InputType type)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
