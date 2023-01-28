using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupRandomOptionProbability")]
public class PopupRandomOptionProbability : PopupBase
{
	private Dictionary<int, long> _gradeProbability;

	private long _gradeProbabilityTotal;

	private Dictionary<int, Dictionary<int, double>> _optionProbability;

	public void InitPopup(int randomOptionType)
	{
	}

	private void CalcData(int randomOptionType)
	{
	}

	private void UpdateView()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
