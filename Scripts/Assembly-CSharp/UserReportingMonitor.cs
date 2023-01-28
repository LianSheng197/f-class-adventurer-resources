using UnityEngine;

public class UserReportingMonitor : MonoBehaviour
{
	public bool IsEnabled;

	public bool IsEnabledAfterTrigger;

	public bool IsHiddenWithoutDimension;

	public string MonitorName;

	public string Summary;

	private void Start()
	{
	}

	public void Trigger()
	{
	}

	protected virtual void Triggered()
	{
	}
}
