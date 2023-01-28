using UnityEngine;

public class BattleObjectArrow : MonoBehaviour
{
	private BattleObjectHero _attacker;

	private BattleThrowManager.ArrowData _arrowData;

	private DesignCharacter.Data _designCharacterAttacker;

	private Vector3 _startPos;

	private Vector3 _targetPos;

	public void Init(BattleObjectHero attacker, BattleThrowManager.ArrowData arrowData, float arrowHeight, float arrowSpeed, bool noRotation, bool arrowGround, float destroyTime)
	{
	}

	public void Hit(GameObject obj, int userData1, int userData2)
	{
	}

	private void TargetHit(float destroyTime)
	{
	}

	private void Remove()
	{
	}
}
