using UnityEngine;

[ExecuteInEditMode]
public class PlayerObj : MonoBehaviour
{
	public enum PlayerState
	{
		idle = 0,
		run = 1,
		attack = 2,
		death = 3
	}

	public SPUM_Prefabs _prefabs;

	public float _charMS;

	private PlayerState _currentState;

	public Vector3 _goalPos;

	private void Start()
	{
	}

	private void PlayStateAnimation(PlayerState state)
	{
	}

	private void Update()
	{
	}

	private void DoMove()
	{
	}

	public void SetMovePos(Vector2 pos)
	{
	}
}
