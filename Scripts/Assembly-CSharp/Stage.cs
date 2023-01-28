using System;

[Serializable]
public class Stage
{
	public long _idx;

	public int _userId;

	public int _worldId;

	public int _stage;

	public int _playCount;

	public DesignWorld.Data GetDesignWorld()
	{
		return null;
	}

	public DesignStage.Data GetDesignStage()
	{
		return null;
	}
}
