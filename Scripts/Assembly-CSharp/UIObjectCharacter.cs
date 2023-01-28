using UnityEngine;

public class UIObjectCharacter : MonoBehaviour
{
	public DesignCharacter.Data _designCharacter;

	public DesignActor.Data _designActor;

	public UIWidget _renderTarget;

	public int _renderQValue;

	private CharacterResBase _characterResBase;

	public static UIObjectCharacter Add(GameObject parent, Character character, UIWidget renderTarget, int renderQValue, string initAni = "victory")
	{
		return null;
	}

	public static UIObjectCharacter Add(GameObject parent, DesignCharacter.Data designCharacter, DesignActor.Data designActor, UIWidget renderTarget, int renderQValue, string initAni = "victory")
	{
		return null;
	}

	public void Init(DesignCharacter.Data designCharacter, DesignActor.Data designActor, UIWidget renderTarget, int renderQValue, string initAni)
	{
	}

	public void ChangeAnimation(string animation)
	{
	}

	public void SetRenderQValue(int value)
	{
	}

	public int GetRenderQValue()
	{
		return 0;
	}

	public void SetFlipX(bool isFlipX)
	{
	}

	public void ShowShadow(bool isShow)
	{
	}

	public void SetWeapon(int itemId)
	{
	}

	public void SetDeath()
	{
	}

	public void SetPressEvent(UIEventListener.VoidDelegate del)
	{
	}
}
