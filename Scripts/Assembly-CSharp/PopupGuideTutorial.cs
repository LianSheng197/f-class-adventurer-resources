using UnityEngine;

[AddComponentMenu("Popup/PopupGuideTutorial")]
public class PopupGuideTutorial : PopupBase
{
	private GuideMissionProgressData _data;

	private DesignGuideMission.Data _designGuideMission;

	private DesignUpdateGuideMission.Data _designUpdateGuideMission;

	private Transform _touchPosition;

	private GameObject _circle;

	private int _step;

	public UIButton _target;

	private Vector3 _targetCenter;

	private void Update()
	{
	}

	public void InitPopup()
	{
	}

	private void NextStep()
	{
	}

	private void SetTarget(Transform start, string[] split)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
