using UnityEngine;

public class InstanceInput : MonoBehaviour
{
	private static InstanceInput _instance;

	private UILabel _label;

	private UIInput _input;

	public static InstanceInput Instance => null;

	public void Initialize()
	{
	}

	public void Reset()
	{
	}

	public UILabel GetLabel()
	{
		return null;
	}

	public UIInput GetInput()
	{
		return null;
	}

	public string GetString()
	{
		return null;
	}

	public void SetOnSubmit(EventDelegate inputEvent)
	{
	}

	public void Select()
	{
	}
}
