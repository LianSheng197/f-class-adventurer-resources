using UnityEngine;

namespace Unity.Services.Analytics
{
	public static class ContainerObject
	{
		private static bool s_Created;

		private static GameObject s_Container;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Initialize()
		{
		}

		public static void DestroyContainer()
		{
		}
	}
}
