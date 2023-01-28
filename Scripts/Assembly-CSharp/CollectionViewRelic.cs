using System.Collections.Generic;
using UnityEngine;

public class CollectionViewRelic : CollectionViewBase
{
	private GameObject _prefabCard;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UILabel _collectLabel;

	private UISlider _collectGraph;

	private Transform _detailInfo;

	private UIScrollView _detailScrollView;

	private UIGrid _detailGrid;

	private GameObject _left;

	private GameObject _right;

	private UILabel _groupDescription;

	private GameObject _groupNotHave;

	private UILabel _groupCollectLabel;

	private UISlider _groupCollectGraph;

	private Dictionary<int, RelicGroupData> _relicGroupData;

	private Dictionary<int, CompRelic> _compRelicList;

	private int _selectRelicGroupId;

	public override void Init()
	{
	}

	public override void UpdateView()
	{
	}

	public override void Ack(AckState ackState, int id = 0)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public override bool IsClose()
	{
		return false;
	}

	public override void UpdateItem()
	{
	}

	public override void UpdateNew()
	{
	}

	private void MakeRelic()
	{
	}

	private void SelectRelicGroup(UIButton btn)
	{
	}

	public int GetSiblingIndex(int id)
	{
		return 0;
	}

	public int GetIndexId(int index)
	{
		return 0;
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private void UpdateDetailView()
	{
	}
}
