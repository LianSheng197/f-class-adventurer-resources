using UnityEngine;

public class MyWorldBossRank : MonoBehaviour
{
	private float _lastUpdateTime;

	private const int _updateFrame = 60;

	private const int worldId = 301;

	private int _worldBossRank;

	private static MyWorldBossRank _instance;

	public static MyWorldBossRank Instance => null;

	public static void Destroy()
	{
	}

	public int GetWorldId()
	{
		return 0;
	}

	public int GetWorldBossRank()
	{
		return 0;
	}

	public void ReqUpdateRank(bool isForce = false)
	{
	}

	private void OnWorldRankingCallback(WWWData wwwData)
	{
	}

	public void SetBossRank(int myRank)
	{
	}

	public void UpdateUI()
	{
	}
}
