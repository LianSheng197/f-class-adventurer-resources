using UnityEngine;

public class SupportLanguageList : MonoBehaviour
{
	public SupportLanguage.Language[] _supportLanguageList;

	private static string mCurrentDeviceLanguage;

	public static SupportLanguage.Language GetCurrentSystemLanguage()
	{
		return default(SupportLanguage.Language);
	}

	public static string GetLocale()
	{
		return null;
	}
}
