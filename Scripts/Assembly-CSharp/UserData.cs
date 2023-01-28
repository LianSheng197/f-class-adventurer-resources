public class UserData
{
	private static string privateKey;

	public static string[] keys;

	public static string Md5(string strToEncrypt)
	{
		return null;
	}

	public static void SaveEncryption(string key, string type, string value)
	{
	}

	public static bool CheckEncryption(string key, string type, string value)
	{
		return false;
	}

	public static void SetInt(string key, int value)
	{
	}

	public static void SetFloat(string key, float value)
	{
	}

	public static void SetString(string key, string value)
	{
	}

	public static int GetInt(string key)
	{
		return 0;
	}

	public static float GetFloat(string key)
	{
		return 0f;
	}

	public static string GetString(string key)
	{
		return null;
	}

	public static int GetInt(string key, int defaultValue)
	{
		return 0;
	}

	public static float GetFloat(string key, float defaultValue)
	{
		return 0f;
	}

	public static string GetString(string key, string defaultValue)
	{
		return null;
	}

	public static bool HasKey(string key)
	{
		return false;
	}

	public static void DeleteKey(string key)
	{
	}

	public static void DeleteAll()
	{
	}
}
