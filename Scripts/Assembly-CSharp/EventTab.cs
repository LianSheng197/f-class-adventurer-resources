using UnityEngine;

public class EventTab : MonoBehaviour
{
	public enum Type
	{
		Event = 0,
		Mission = 1,
		SpecialMission = 2,
		CardOpen = 3
	}

	private PopupEvent _popupEvent;

	public Type _type;

	public int _id;

	private GameObject _new;

	public void Init(PopupEvent popupEvent, Type type, int id)
	{
	}

	public void SelectTab(UIButton btn)
	{
	}

	public void UpdateNew()
	{
	}

	private void SetIcon(UISprite sprite)
	{
	}

	private string GetSpriteName()
	{
		return null;
	}
}
