using UnityEngine;

public class LegendCard : MonoBehaviour
{
	private Legend _legend;

	private DesignLegend.Data _designLegend;

	private DesignLegendFameUp.Data _designLegendFameUp;

	private DesignLegendFame.Data _designLegendFame;

	private GameObject _on;

	public static LegendCard Add(GameObject parent, int legendId)
	{
		return null;
	}

	public static LegendCard Add(GameObject parent, Legend legend)
	{
		return null;
	}

	public Legend GetLegend()
	{
		return null;
	}

	public void SetCard(int legendId)
	{
	}

	public void SetCard(Legend legend)
	{
	}

	public void UpdateInfo()
	{
	}

	public void UpdateSubInfo()
	{
	}

	public void NotHave(bool isNotHave)
	{
	}

	public void SetNew(bool isNew)
	{
	}

	public UIWidget GetRenderTarget()
	{
		return null;
	}
}
