using UnityEngine;

public class PotentialStatItem : MonoBehaviour
{
	public delegate void ToolTipDelegate(PotentialStatItem card);

	public int _idx;

	private Character _character;

	private ToolTipDelegate _tooltipCallback;

	public void Init(Character character, int idx, ToolTipDelegate tooltipDelegate = null)
	{
	}

	public void SetStat()
	{
	}

	public void HideStat()
	{
	}

	public void ShowEffect(float delay)
	{
	}

	public void SetToolTipDelegate(ToolTipDelegate tooltipDelegate)
	{
	}

	public void ShowToolTip(UIButton btn)
	{
	}

	public void UpdateStat()
	{
	}
}
