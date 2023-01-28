using UnityEngine;

public static class AndroidRuntimePermissions
{
	public enum Permission
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2
	}

	public delegate void PermissionResult(string permission, Permission result);

	public delegate void PermissionResultMultiple(string[] permissions, Permission[] result);

	private static AndroidJavaClass m_ajc;

	private static AndroidJavaObject m_context;

	private static AndroidJavaClass AJC => null;

	private static AndroidJavaObject Context => null;

	public static void OpenSettings()
	{
	}

	public static Permission CheckPermission(string permission)
	{
		return default(Permission);
	}

	public static Permission[] CheckPermissions(params string[] permissions)
	{
		return null;
	}

	public static Permission RequestPermission(string permission)
	{
		return default(Permission);
	}

	public static Permission[] RequestPermissions(params string[] permissions)
	{
		return null;
	}

	private static void RequestPermissionAsync(string permission, PermissionResult callback)
	{
	}

	private static void RequestPermissionsAsync(string[] permissions, PermissionResultMultiple callback)
	{
	}

	public static Permission[] ProcessPermissionRequest(string[] permissions, string resultRaw)
	{
		return null;
	}

	private static Permission GetCachedPermission(string permission, Permission defaultValue)
	{
		return default(Permission);
	}

	private static string GetCachedPermissions(string[] permissions)
	{
		return null;
	}

	private static bool CachePermission(string permission, Permission value)
	{
		return false;
	}

	private static void ValidateArgument(string[] permissions)
	{
	}

	private static Permission[] GetDummyResult(string[] permissions)
	{
		return null;
	}

	private static Permission ToPermission(this char ch)
	{
		return default(Permission);
	}
}
