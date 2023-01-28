using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultiScaleCamera : MonoBehaviour
{
	public enum ScalePolicy
	{
		SHOW_ALL = 0,
		EXACT_FIT = 1,
		FIXED_WIDTH = 2,
		FIXED_HEIGHT = 3,
		NO_BORDER = 4,
		STRETCH = 5
	}

	public float desiredWidth;

	public float desiredHeight;

	public float pixelsToUnits;

	public ScalePolicy scalePolicy;

	public void Set()
	{
	}

	public void Set2()
	{
	}
}
