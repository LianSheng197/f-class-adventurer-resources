using System.Runtime.CompilerServices;
using UnityEngine;

namespace AndroidRuntimePermissionsNamespace
{
	public class PermissionCallback : AndroidJavaProxy
	{
		private object threadLock;

		public string Result
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PermissionCallback(object threadLock)
			: base((string)null)
		{
		}

		public void OnPermissionResult(string result)
		{
		}
	}
}
