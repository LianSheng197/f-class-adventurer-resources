using UnityEngine;

public class Loading : MonoBehaviour
{
	private static Loading _instance;

	private UISlider _progress;

	private int _loadingStep;

	private int _curStep;

	private float _curValue;

	private float _nextValue;

	public static Loading Instance => null;

	public static void AddLoadingStep()
	{
	}

	private void Update()
	{
	}

	public void StartLoading()
	{
	}

	public void AddStep()
	{
	}

	public void EndLoading()
	{
	}

	private void SelfDestroy()
	{
	}
}
