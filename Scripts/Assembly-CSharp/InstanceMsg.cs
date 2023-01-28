using UnityEngine;

public class InstanceMsg : MonoBehaviour
{
	public enum Position
	{
		Top = 0,
		Center = 1,
		Bottom = 2
	}

	private const int BaseDepth = 30000;

	private static InstanceMsg _instance;

	public GameObject _prefabInstanceMsg;

	public static InstanceMsg Instance => null;

	private void InitInstanceMsg()
	{
	}

	public void AddMsg(string msg, Position pos = Position.Top, float duration = 1f)
	{
	}

	public void AddMsg(int languageID, Position pos = Position.Top, float duration = 1f)
	{
	}

	public int GetOffsetDepth()
	{
		return 0;
	}
}
