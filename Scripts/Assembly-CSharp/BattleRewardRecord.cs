using System.Collections.Generic;

public class BattleRewardRecord
{
	public const float _maxTime = 43200f;

	public int _playStageId;

	public float _time;

	public Dictionary<int, long> _rewards;

	public void Clear()
	{
	}

	public void PlayStage(int stageId)
	{
	}

	public void AddTime(float deltaTime)
	{
	}

	public void AddReward(List<ItemReward> rewards)
	{
	}

	private void AddItemReward(ItemReward reward)
	{
	}
}
