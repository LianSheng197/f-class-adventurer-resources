using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[ExecuteInEditMode]
public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}
}
