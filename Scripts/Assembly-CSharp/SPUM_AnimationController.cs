using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SPUM_AnimationController : MonoBehaviour
{
	[Header("Character Animator")]
	[SerializeField]
	private SPUM_Prefabs unit;

	[Header("Animation Button Prefab")]
	[SerializeField]
	private Button animationButtonPrefab;

	[SerializeField]
	private Transform animationButtonParent;

	[Header("Animation Play Controller")]
	[SerializeField]
	private Slider timeLineSlider;

	[SerializeField]
	private Slider playSpeedSlider;

	[SerializeField]
	private Text slidertimeLineInfo;

	[SerializeField]
	private Text timeLineText;

	[SerializeField]
	private Text playSpeedText;

	[SerializeField]
	private Animator animator => null;

	private void Start()
	{
	}

	private void Init()
	{
	}

	private void RemoveAllAnimationButtons()
	{
	}

	private void InitAnimationButtons()
	{
	}

	private void SetAnimationNormailzedTime(float progress)
	{
	}

	private void CreateAnimationButton(Transform parent, string animationClip, UnityAction Action)
	{
	}
}
