using System.Collections.Generic;

public class Config
{
	public static Dictionary<string, string> _dicEnvironmentConfig;

	public static Dictionary<string, string> _dicParticialConnectConfig;

	public static Dictionary<string, string> _dicConnectConfig;

	public static Dictionary<byte, Dictionary<string, string>> _dicAssetCRCConfig;

	public static void InitEnvironmentConfig(string data)
	{
	}

	public static void InitParticialConnectConfig(string data)
	{
	}

	public static void InitAssetCRCConfig(string data)
	{
	}

	public static void InitConnectConfig(string data)
	{
	}

	public static string GetEnvironmentConfig(string key)
	{
		return null;
	}

	public static int GetEnvironmentConfig(string key, int def)
	{
		return 0;
	}

	public static string GetConnectConfig(string key)
	{
		return null;
	}
}
