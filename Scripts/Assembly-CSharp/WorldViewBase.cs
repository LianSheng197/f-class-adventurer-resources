using UnityEngine;

public class WorldViewBase : MonoBehaviour
{
	protected GameObject _prefab;

	protected UIScrollView _scrollView;

	protected UIGrid _grid;

	public virtual void Init()
	{
	}

	public virtual void MakeList()
	{
	}

	public virtual void UpdateView()
	{
	}

	public virtual bool UpdateNew()
	{
		return false;
	}

	public virtual void Message(UIButton btn)
	{
	}

	public virtual void InitSelect(int worldId, int stage)
	{
	}

	public virtual int RefreshWorldList()
	{
		return 0;
	}

	public virtual void UpdateLevelUp()
	{
	}
}
