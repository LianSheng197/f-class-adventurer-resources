using UnityEngine;

public class BattleDPad : MonoBehaviour
{
	private GameObject _object;

	private GameObject _pad;

	private bool _isPress;

	private float _radius;

	private GameObject _hitObject;

	public static BattleDPad Add(GameObject target)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	public bool IsUsing()
	{
		return false;
	}

	public Vector3 GetDir()
	{
		return default(Vector3);
	}

	private void OnPress(GameObject obj, bool state)
	{
	}

	private void UpdateDPad()
	{
	}

	private bool UpdateAxisDPad()
	{
		return false;
	}
}
