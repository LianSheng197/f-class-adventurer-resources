using UnityEngine;

public class GachaCard : MonoBehaviour
{
	private Transform _lvForm;

	public Transform _gridForm;

	public int _gachaIdx;

	public GachaConsumeState _consumeData;

	public GachaConsumeState _consumeData2;

	private UITexture _tex;

	private Transform _notOpen;

	private UILabel _notOpenLabel;

	private DesignItem.Data _moveDesignItem;

	private GameObject _lvUpRewardButton;

	public GachaGroup _gachaGroup => null;

	private void UpdateConsumeData()
	{
	}

	private void UpdateConsumeData2()
	{
	}

	public void Init(int gachaIdx)
	{
	}

	public bool CheckOpen()
	{
		return false;
	}

	public bool CheckOpenLevel()
	{
		return false;
	}

	public bool CheckOpenStage()
	{
		return false;
	}

	public void UpdateUI()
	{
	}

	private void InitBG()
	{
	}

	private void InitInfo()
	{
	}

	private void InitSummonBtn(GameObject obj, int index)
	{
	}

	public void GoShop(GameObject obj, UIButton btn)
	{
	}

	public void ShowInfo()
	{
	}

	public void Buy(UIButton btn, int index)
	{
	}
}
