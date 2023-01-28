using UnityEngine;

namespace AndroidRuntimePermissionsNamespace
{
	public class PermissionCallbackAsync : AndroidJavaProxy
	{
		private string result;

		private string[] permissions;

		private AndroidRuntimePermissions.PermissionResultMultiple callback;

		public PermissionCallbackAsync(string[] permissions, AndroidRuntimePermissions.PermissionResultMultiple callback)
			: base((string)null)
		{
		}

		public void OnPermissionResult(string result)
		{
		}

		private void ExecuteCallback()
		{
		}
	}
}
