using System;
using System.Collections.Generic;
using UnityEngine;

public class AntiCheatIntegration : MonoBehaviour
{
	private static AntiCheatIntegration instance;

	private DateTime lastCheckTime_1Min;

	private DateTime lastCheckTime_10Min;

	public AccountOption accountOption;

	private bool initialize;

	private bool isSpeedHackDetected;

	private List<ClientSave> clientSaves;

	public float minCoolTime;

	public List<int> targetSkill;

	public float minTargetCoolTime;

	public float minGlobalCoolTime;

	public float minAttackDuration;

	public float maxRealMoveSpeedBase;

	public float maxRealMoveSpeedBase2;

	public float maxRealMoveSpeedOffset;

	public float maxRealMoveSpeed;

	public float maxRealMove;

	public StatisticsData realMoveDeltaTime;

	public float minRealAttackSpeed;

	private bool isSkillLevel1Detected;

	private bool isSkillLevel2Detected;

	public static AntiCheatIntegration Instance => null;

	private void Update()
	{
	}

	public void Initialize()
	{
	}

	private void OnSpeedHackDetected()
	{
	}

	private void Check_1Min()
	{
	}

	private void Check_10Min()
	{
	}

	private void CheckEquipmentLevel()
	{
	}

	private void CheckSkillCoolTime()
	{
	}

	private void CheckCharacter()
	{
	}

	private void CheckLegendFame()
	{
	}

	private void CheckSkillLevel()
	{
	}

	private void OnSkillLevel1Detected(List<int> datas)
	{
	}

	private void OnSkillLevel2Detected(List<int> datas)
	{
	}
}
