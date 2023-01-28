using UnityEngine;

namespace socket.io
{
	public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		private static object _lock;

		private static bool applicationIsQuitting;

		public static T Instance => null;

		public void OnDestroy()
		{
		}
	}
}
