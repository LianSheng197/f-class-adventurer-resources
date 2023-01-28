using UnityEngine;

public class DrawBoxLine : MonoBehaviour
{
	private Color color;

	private LineRenderer lineRenders;

	private Vector3[] vertexs;

	private Vector3 v3FrontTopLeft;

	private Vector3 v3FrontTopRight;

	private Vector3 v3FrontBottomLeft;

	private Vector3 v3FrontBottomRight;

	private Vector3 v3BackTopLeft;

	private Vector3 v3BackTopRight;

	private Vector3 v3BackBottomLeft;

	private Vector3 v3BackBottomRight;

	private void Awake()
	{
	}

	public void ShowLine(bool isShow)
	{
	}

	public void DrawLine(BoxCollider inCollider)
	{
	}
}
