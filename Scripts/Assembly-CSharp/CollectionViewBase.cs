using UnityEngine;

public class CollectionViewBase : MonoBehaviour
{
	public enum AckState
	{
		RelicMake = 0,
		RelicLevelUp = 1,
		PowerStoneMaterial = 2,
		LegendLearn = 3,
		LegendEquip = 4,
		LegendLevelUp = 5,
		LegendFameUp = 6,
		TreasureBuy = 7,
		TreasureSell = 8,
		TreasureLevelUp = 9,
		ArtifactGacha = 10,
		ArtifactGachaRecordReward = 11,
		ArtifactUpgrade = 12,
		ArtifactExpandLevel = 13,
		ArtifactDivide = 14
	}

	public virtual void Init()
	{
	}

	public virtual void EnterView()
	{
	}

	public virtual void ExitView()
	{
	}

	public virtual void UpdateView()
	{
	}

	public virtual void Ack(AckState ackState, int id = 0)
	{
	}

	public virtual void Message(UIButton btn)
	{
	}

	public virtual bool IsClose()
	{
		return false;
	}

	public virtual void UpdateItem()
	{
	}

	public virtual void UpdateNew()
	{
	}
}
