using UnityEngine;

public class CrashReportIntegration : MonoBehaviour
{
	public FirebaseCrashReportIntegration firebaseCrashReport;

	private static CrashReportIntegration instance;

	private bool initialize;

	public static CrashReportIntegration Instance => null;

	public void Initialize()
	{
	}

	public void StartSession()
	{
	}

	public void LogUserId(string userId)
	{
	}

	public void LogUserPermission(string permission)
	{
	}
}
