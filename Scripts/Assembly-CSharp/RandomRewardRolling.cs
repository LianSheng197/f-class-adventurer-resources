using System.Collections.Generic;
using UnityEngine;

public class RandomRewardRolling : MonoBehaviour
{
	public delegate void RandomRewardRollingDelegate();

	private RandomRewardRollingDelegate _delegate;

	private ItemCard _itemCard;

	private int _finishIndex;

	private List<ItemReward> _rollingRewards;

	private int _rollingCount;

	private float _rollingTime;

	public void Init(ItemReward reward, RandomRewardRollingDelegate del)
	{
	}

	private void RandomRolling()
	{
	}
}
