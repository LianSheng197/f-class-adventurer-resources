using UnityEngine;

public class BattleBackground : MonoBehaviour
{
	public enum Movement
	{
		Horizontal = 0,
		Vertical = 1,
		Unrestricted = 2,
		Max = 3
	}

	public Movement _movement;

	public Transform _target;

	public float _offset;

	public static BattleBackground Get(GameObject obj)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init(Transform target, Movement movement, float offset = 1f)
	{
	}

	private void UpdatePosition()
	{
	}
}
