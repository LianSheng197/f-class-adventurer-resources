using UnityEngine;

public class NaverGameManager : MonoBehaviour
{
	public enum State
	{
		closed = 0,
		init = 1
	}

	private string LoungeId;

	private string NaverLoginClientId;

	private string NaverLoginClientSecret;

	private static NaverGameManager _instance;

	private State _currentState;

	private int _boardId;

	public static NaverGameManager Instance => null;

	public State GetState()
	{
		return default(State);
	}

	public void Init()
	{
	}

	public bool IsNaverDefine()
	{
		return false;
	}

	public void GoHome()
	{
	}

	public void GoBoard(int boardId)
	{
	}

	public void GoFeed(int feedId, bool isTempFeed)
	{
	}

	public void Close()
	{
	}
}
