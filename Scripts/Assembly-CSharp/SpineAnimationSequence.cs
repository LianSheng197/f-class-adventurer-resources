using Spine;
using Spine.Unity;
using UnityEngine;

public class SpineAnimationSequence : MonoBehaviour
{
	public delegate void AnimationSequenceDelegate(GameObject obj);

	private AnimationSequenceDelegate _animationSequenceCallback;

	private SkeletonAnimation _skeletonAnimation;

	public static SpineAnimationSequence Add(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Play(string aniName, AnimationSequenceDelegate completeDelegate = null)
	{
	}

	private void DefaultComplete(TrackEntry trackEntry)
	{
	}
}
