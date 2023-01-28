using UnityEngine;

public class ResolutionClipSize : MonoBehaviour
{
	public enum Type
	{
		Normal = 0,
		Horizontal = 1,
		Vertical = 2
	}

	[HideInInspector]
	public bool _ignore;

	public Type _type;

	private void Awake()
	{
	}

	private void Resolution()
	{
	}

	private void SelfDestroy()
	{
	}
}
