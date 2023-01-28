using UnityEngine;

public class Shaking : MonoBehaviour
{
	private bool _shaking;

	private float _time;

	private float _shakeAmount;

	private Vector3 _originalPos;

	private bool _freezeX;

	private bool _freezeY;

	private bool _freezeZ;

	public static Shaking Add(GameObject target)
	{
		return null;
	}

	public void Init()
	{
	}

	private void Update()
	{
	}

	public void StartShaking(float time, float shakeAmount)
	{
	}

	public void StopShaking()
	{
	}

	public void Freeze(bool freezeX, bool freezeY, bool freezeZ)
	{
	}
}
