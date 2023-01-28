using Spine.Unity;
using UnityEngine;

public class SpineFadeEffect : MonoBehaviour
{
	public delegate void FadeDelegate();

	public enum FadeType
	{
		None = 0,
		In = 1,
		Out = 2
	}

	private FadeDelegate _fadeDelegate;

	private FadeType _fadeType;

	private float _start;

	private float _end;

	private float _time;

	private float _speed;

	private SkeletonAnimation _skeletonAnimation;

	public static SpineFadeEffect Add(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void FadeIn(FadeDelegate del = null)
	{
	}

	public void FadeOut(FadeDelegate del = null)
	{
	}

	private void EndFade()
	{
	}
}
