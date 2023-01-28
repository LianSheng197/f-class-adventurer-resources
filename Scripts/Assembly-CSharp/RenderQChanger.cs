using UnityEngine;

[ExecuteInEditMode]
public class RenderQChanger : MonoBehaviour
{
	public Material _mat;

	public int _renderQueue;

	public MeshRenderer _meshRender;

	private Material _changeMaterial;

	private bool _isChange;

	public static RenderQChanger Get(GameObject obj)
	{
		return null;
	}

	public static void AllReset(GameObject obj)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitRenderQueue()
	{
	}

	public void Reset()
	{
	}

	private void OnEnable()
	{
	}

	public void ReChange()
	{
	}

	public bool IsChange()
	{
		return false;
	}

	public void ChangeRenderQueue(int renderQueue)
	{
	}

	public void ForceInit()
	{
	}
}
