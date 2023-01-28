using UnityEngine;

public class BattleTileMap : MonoBehaviour
{
	private BattleData _battleData;

	public void Init(BattleData battleData)
	{
	}

	public bool IsCollision(BattleObjectBase battleObject, Vector3 dir)
	{
		return false;
	}

	public bool IsCollision(Vector3 origin, Vector3 dir)
	{
		return false;
	}

	public Vector3 CollisionCorrectJumpPos(Vector3 origin, Vector3 dir, Vector3 movePos)
	{
		return default(Vector3);
	}
}
