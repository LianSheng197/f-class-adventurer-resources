using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Services.Analytics
{
	public class AnalyticsLifetime : MonoBehaviour
	{
		private const float k_HeartbeatPeriod = 60f;

		private const float k_GameRunningPeriod = 60f;

		private float m_HeartbeatTime;

		private float m_GameRunningTime;

		internal static AnalyticsLifetime Instance
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

		internal float TimeUntilHeartbeat => 0f;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
