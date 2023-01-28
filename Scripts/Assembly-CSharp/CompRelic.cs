using UnityEngine;

public class CompRelic : MonoBehaviour
{
	private int _relicId;

	private Relic _relic;

	private DesignRelic.Data _designRelic;

	private UILabel _relicLevel;

	private UILabel _countLabel;

	private UISlider _countGraph;

	private UILabel _description;

	private GameObject _notHave;

	private Transform _lvUpBtn;

	private Transform _lvOn;

	private Transform _lvOnRuby;

	private UILabel _lvOnRubyLabel;

	private Transform _sellBtn;

	private Transform _sellOn;

	private Transform _sellOff;

	private GameObject _new;

	private GameObject _effectPosition;

	private long _rubyCost;

	public void Init(int relicId)
	{
	}

	public void UpdateView()
	{
	}

	public void UpdateNew()
	{
	}

	public void Ack(CollectionViewBase.AckState ackState)
	{
	}

	private void GetConfirm(bool confirm)
	{
	}

	private void LvUpConfirm(bool confirm)
	{
	}

	private void Message(UIButton btn)
	{
	}
}
