using UnityEngine;

public class ItemCharacterCard : BaseCard
{
	public const int _imteIdLinkValue = 200000;

	public DesignCharacter.Data _designCharacter;

	public static ItemCharacterCard Add(GameObject parent, Character data = null)
	{
		return null;
	}

	public static ItemCharacterCard Add(GameObject parent, int charcterId)
	{
		return null;
	}

	protected override void InitData()
	{
	}

	public override void UpdateInfo()
	{
	}

	public void SetImageFlip()
	{
	}

	public void SetCollectionInfo(bool isNoHave)
	{
	}

	public void Select(bool isSelect)
	{
	}
}
