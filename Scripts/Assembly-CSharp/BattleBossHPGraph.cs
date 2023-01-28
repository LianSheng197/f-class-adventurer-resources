using System.Collections.Generic;
using UnityEngine;

public class BattleBossHPGraph : MonoBehaviour
{
	private BattleData _battleData;

	private UISlider _hpSlider;

	private UISprite _nowHPSprite;

	private UISprite _nextSprite;

	private UISlider _effectSlider;

	private TweenSlider _tweenSlider;

	private bool _isInfinity;

	private double _barHP;

	private double _hp;

	private double _hpMax;

	private double _damage;

	private List<Color> _hpColor;

	private int _hpColorIndex;

	public void Init(BattleData battleData, double barHP, double maxHP)
	{
	}

	public void AddDamage(double damage)
	{
	}

	public void AddHP(double hp)
	{
	}

	private void Update()
	{
	}

	private void SetupHPColor(bool isNext)
	{
	}

	private void StartSlider(float to, float duration)
	{
	}
}
