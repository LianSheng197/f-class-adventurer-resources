using UnityEngine;

[AddComponentMenu("NGUI/Internal/Snapshot Point")]
[ExecuteInEditMode]
public class UISnapshotPoint : MonoBehaviour
{
	public bool isOrthographic;

	public float nearClip;

	public float farClip;

	[Range(10f, 80f)]
	public int fieldOfView;

	public float orthoSize;

	public Texture2D thumbnail;

	private void Start()
	{
	}
}
