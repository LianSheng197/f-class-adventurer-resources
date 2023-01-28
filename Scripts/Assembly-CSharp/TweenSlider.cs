using UnityEngine;

public class TweenSlider : UITweener
{
	public float from;

	public float to;

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenSlider Begin(GameObject go, float duration, float toValue)
	{
		return null;
	}

	public static TweenSlider Begin(GameObject go, float duration, float fromValue, float toValue, Method method = Method.Linear)
	{
		return null;
	}
}
