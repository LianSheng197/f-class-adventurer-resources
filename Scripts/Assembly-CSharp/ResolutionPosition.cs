using UnityEngine;

public class ResolutionPosition : MonoBehaviour
{
	public enum Type
	{
		Normal = 0,
		Horizontal = 1,
		Vertical = 2
	}

	public static bool _lock;

	public Type _type;

	[HideInInspector]
	public bool _ignore;

	private bool _isFixX;

	private bool _isFixY;

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
