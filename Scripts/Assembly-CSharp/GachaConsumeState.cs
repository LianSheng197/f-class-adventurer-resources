using System.Collections.Generic;

public class GachaConsumeState
{
	private int _buyCount;

	public Dictionary<int, long> _dicMaterial;

	public Dictionary<int, int> _countEachMaterial;

	private GachaGroup _gachaGroup;

	public void GetData(int index, out DesignItem.Data designItem, out int itemId, out long itemCount, out int eachCount, out int validBuyCount)
	{
		designItem = null;
		itemId = default(int);
		itemCount = default(long);
		eachCount = default(int);
		validBuyCount = default(int);
	}

	public void GetConditionData(int index, out DesignItem.Data designItem, out int itemId, out long itemCount, out int eachCount, int gachaCountIndex)
	{
		designItem = null;
		itemId = default(int);
		itemCount = default(long);
		eachCount = default(int);
	}

	public bool IsMixed()
	{
		return false;
	}

	public bool IsMixedMaterialState()
	{
		return false;
	}

	public static void UpdateState(GachaGroup gachaGroup, out GachaConsumeState data, int gachaCountIndex)
	{
		data = null;
	}
}
