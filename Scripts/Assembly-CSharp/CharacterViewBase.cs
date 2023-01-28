using System.Collections.Generic;
using UnityEngine;

public class CharacterViewBase : MonoBehaviour
{
	protected DesignUpgrade.Data.Type _type;

	protected GameObject _prefab;

	protected UIScrollView _scrollView;

	protected UIGrid _grid;

	protected Dictionary<int, CharacterViewItem> _objectList;

	private List<int> _removeNewList;

	public virtual void Init(DesignUpgrade.Data.Type type)
	{
	}

	public virtual void LoadPrefabItem()
	{
	}

	public virtual void UpdateView()
	{
	}

	public virtual void AckUpgrade(int id = 0)
	{
	}

	public virtual void Message(UIButton btn)
	{
	}

	public void ChangeUpgradeCount(int count)
	{
	}

	public void UpdateNew()
	{
	}

	private void MakeList()
	{
	}

	public void SortList()
	{
	}

	private int SortByLevel(DesignUpgrade.Data a, DesignUpgrade.Data b)
	{
		return 0;
	}
}
