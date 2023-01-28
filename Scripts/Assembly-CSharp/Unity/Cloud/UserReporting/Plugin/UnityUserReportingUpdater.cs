using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Cloud.UserReporting.Plugin
{
	public class UnityUserReportingUpdater : IEnumerator
	{
		private int step;

		private WaitForEndOfFrame waitForEndOfFrame;

		public object Current
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

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}
}
