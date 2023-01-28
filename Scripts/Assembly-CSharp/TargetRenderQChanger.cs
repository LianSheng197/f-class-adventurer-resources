using UnityEngine;

public class TargetRenderQChanger : MonoBehaviour
{
	public enum Mode
	{
		Update = 0,
		Change = 1
	}

	public UIWidget _target;

	public int _renderQ;

	public Mode _mode;

	private RenderQChanger _renderQChanger;

	public static TargetRenderQChanger Get(GameObject obj)
	{
		return null;
	}

	public static void BuildTargetRenderQ(GameObject obj, UIWidget target, int renderQ)
	{
	}

	public static void BuildTargetRenderQ(GameObject obj, UIWidget target)
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

	public void SetTarget(UIWidget target)
	{
	}

	public void SetTarget(UIWidget target, int renderQ)
	{
	}

	public void ChangeRenderQ(int renderQ)
	{
	}

	private void OnRenderCallBack(Material mat)
	{
	}
}
