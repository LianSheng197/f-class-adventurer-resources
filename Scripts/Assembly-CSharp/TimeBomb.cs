using UnityEngine;

public class TimeBomb : MonoBehaviour
{
	public delegate void TimeBombDelegate(GameObject obj);

	private TimeBombDelegate _timeBombDelegate;

	public float _time;

	private float _deltaTime;

	private bool _isStart;

	public static TimeBomb Add(GameObject target)
	{
		return null;
	}

	public static TimeBomb Auto(GameObject target, TimeBombDelegate timeBombDelegate = null, float time = 0f)
	{
		return null;
	}

	private void Update()
	{
	}

	public void SetTime(float time)
	{
	}

	public void StartBomb(TimeBombDelegate timeBombDelegate = null)
	{
	}
}
