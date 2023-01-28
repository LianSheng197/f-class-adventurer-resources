using System;
using UnityEngine;

namespace GoogleMobileAds.Common
{
	public class AppStateEventClient : MonoBehaviour, IAppStateEventClient
	{
		private static AppStateEventClient instance;

		public static AppStateEventClient Instance => null;

		public event Action<AppState> AppStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		private void OnApplicationPause(bool isPaused)
		{
		}
	}
}
