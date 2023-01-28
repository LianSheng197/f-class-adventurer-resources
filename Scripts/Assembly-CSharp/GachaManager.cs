using System.Collections.Generic;

public class GachaManager
{
	private Dictionary<int, GachaGroup> _gachaGroupList;

	private Dictionary<int, GachaRecord> _gachaRecordList;

	private Dictionary<int, GachaRecordReward> _rewards;

	private static GachaManager _instance;

	public static GachaManager instance => null;

	public void Init()
	{
	}

	public void ClearGachaGroupList()
	{
	}

	public void SetGachaGroupList(List<GachaGroup> list)
	{
	}

	public List<GachaGroup> GetGachaList()
	{
		return null;
	}

	public List<GachaGroup> GetActiveGachaList(bool isArtifact)
	{
		return null;
	}

	public int GetActiveGachaCount(bool isArtifact)
	{
		return 0;
	}

	public GachaGroup GetCurrentStep(int gachaGroupIdx)
	{
		return null;
	}

	public GachaGroup GetCurrentStep(GachaGroup gachaGroup)
	{
		return null;
	}

	public GachaGroup GetGachaGroup(int gachaIdx)
	{
		return null;
	}

	public bool IsArtifactGacha(int gachaIdx)
	{
		return false;
	}

	public void SetGachaRecordList(List<GachaRecord> list)
	{
	}

	public void SetGachaRecord(GachaRecord data)
	{
	}

	public GachaRecord GetGachaRecord(int gachaIdx)
	{
		return null;
	}

	public Dictionary<int, GachaRecord> GetGachaStepRecord(int stepGroup)
	{
		return null;
	}

	public GachaRecord GetGachaStepRecord(int stepGroup, int curStep)
	{
		return null;
	}

	public void SetGachaRecordReward(List<GachaRecordReward> rewards)
	{
	}

	public void SetGachaRecordReward(GachaRecordReward reward)
	{
	}

	public GachaRecordReward GetGachaRecordReward(int gachaGroupIdx)
	{
		return null;
	}

	public bool IsFreeGacha(int gachaGroupIdx, int gachaCountIndex)
	{
		return false;
	}

	public bool IsNewGacha()
	{
		return false;
	}

	public bool IsGachaBuy(GachaGroup gachaGroup, int gachaCountIndex)
	{
		return false;
	}

	public GachaGroup GetGachaGroupWithStepGruopId(int stepGroupId)
	{
		return null;
	}
}
