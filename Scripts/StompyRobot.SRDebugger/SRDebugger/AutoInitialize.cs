using UnityEngine;

namespace SRDebugger
{
	public static class AutoInitialize
	{
		private const RuntimeInitializeLoadType InitializeLoadType = RuntimeInitializeLoadType.SubsystemRegistration;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void OnLoadBeforeScene()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void OnLoad()
		{
		}
	}
}
