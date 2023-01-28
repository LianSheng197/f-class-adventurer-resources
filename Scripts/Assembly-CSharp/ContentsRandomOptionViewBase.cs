using System.Collections.Generic;
using UnityEngine;

public class ContentsRandomOptionViewBase : MonoBehaviour
{
	protected RandomOption.eType _type;

	protected int _itemId;

	protected GameObject _root;

	protected UIGrid _grid;

	protected GameObject _prefabLabel;

	protected GameObject _haveLabel;

	protected bool _setUpdate;

	public virtual void Init()
	{
	}

	public virtual void SetData(RandomOption.eType type, int itemId)
	{
	}

	public virtual void UpdateView()
	{
	}

	protected void UpdateView(int openCondition, List<int> openConditionData, DesignRandomOptionHaveEffect.Data designRandomOptionHaveEffect)
	{
	}

	public void SetUpdate()
	{
	}

	private void Message(UIButton btn)
	{
	}
}
