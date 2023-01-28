using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour
{
	public delegate void BulletEffectDelegate();

	private BulletEffectDelegate _callback;

	public List<GameObject> _bulletList;

	public GameObject _showEffect;

	public GameObject _target;

	public Vector2 _appearRangeStart;

	public Vector2 _appearRangeEnd;

	public float _appearHeight;

	public float _appearDurationRangeStart;

	public float _appearDurationRangeEnd;

	public float _appearAcceleration;

	public float _targetDelay;

	public float _targetHeight;

	public float _targetDurationRangeStart;

	public float _targetDurationRangeEnd;

	public float _targetAcceleration;

	public GameObject _finishEffect;

	public float _finishEffectRepeatTime;

	private int _endBulletCount;

	private float _finishTime;

	private void Update()
	{
	}

	public void Play(GameObject target = null, BulletEffectDelegate callback = null)
	{
	}

	private void EndAppear(GameObject obj, int userData1, int userData2)
	{
	}

	private void EndTarget(GameObject obj, int userData1, int userData2)
	{
	}
}
