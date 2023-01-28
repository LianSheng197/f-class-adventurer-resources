using UnityEngine;

[AddComponentMenu("Popup/PopupRandomReward")]
public class PopupRandomReward : PopupBase
{
	private string _animationName;

	private Animation _animation;

	private ActiveAnimation _activeAnimation;

	private bool _isFixAble;

	private bool _isCloseAble;

	private bool _isClosing;

	public void InitPopup(int randomBoxItemId, ItemReward rewardItem)
	{
	}

	private void AnimationEnd()
	{
	}

	private void AnimationFixEnd()
	{
	}

	private void AnimationCloseEnd()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
