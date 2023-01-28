using System.Collections.Generic;

public class GuideMissionManager
{
	private static GuideMissionManager _Instance;

	private GuideMissionProgressData _guideMission;

	private List<GuideMissionProgressData> _guideMissionReq;

	private GuideMissionProgressData _updateGuideMission;

	private List<GuideMissionProgressData> _updateGuideMissionReq;

	public static GuideMissionManager Instance => null;

	public bool IsUpdateGuideMission()
	{
		return false;
	}

	public void SetGuideMission(GuideMissionProgressData guideMissionProgress)
	{
	}

	public GuideMissionProgressData GetGuideMission()
	{
		return null;
	}

	public void AddGuideMissionProgressData(GuideMissionProgressData data)
	{
	}

	public List<GuideMissionProgressData> GetGuideMissionProgressReq()
	{
		return null;
	}

	public void ClearGuideMissionProgressReq()
	{
	}

	public void SetUpdateGuideMission(GuideMissionProgressData guideMissionProgress)
	{
	}

	public GuideMissionProgressData GetUpdateGuideMission()
	{
		return null;
	}

	public void AddUpdateGuideMissionProgressData(GuideMissionProgressData data)
	{
	}

	public List<GuideMissionProgressData> GetUpdateGuideMissionProgressReq()
	{
		return null;
	}

	public void ClearUpdateGuideMissionProgressReq()
	{
	}

	public bool IsRemainProgressQueue()
	{
		return false;
	}
}
