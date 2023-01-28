using System.Collections.Generic;
using UnityEngine;

public class BattleBossScarecrowGraph : MonoBehaviour
{
	private BattleData _battleData;

	private UISlider _hpSlider;

	private UISprite _nowHPSprite;

	private UISprite _nextSprite;

	private UISlider _effectSlider;

	private TweenSlider _tweenSlider;

	private double _hp;

	private double _hpMax;

	private double _damage;

	private List<Color> _hpColor;

	private int _hpColorIndex;

	public void Init(BattleData battleData, double startBar)
	{
	}

	public void AddDamage(double damage)
	{
	}

	private void Update()
	{
	}

	private void SetupHPColor()
	{
	}

	private void StartSlider(float to, float duration)
	{
	}
}
