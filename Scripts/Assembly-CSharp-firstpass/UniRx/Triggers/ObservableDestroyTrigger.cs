using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableDestroyTrigger : MonoBehaviour
	{
		private bool calledDestroy;

		private Subject<Unit> onDestroy;

		private CompositeDisposable disposablesOnDestroy;

		[Obsolete("Internal Use.")]
		internal bool IsMonitoredActivate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsActivated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsCalledOnDestroy => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public IObservable<Unit> OnDestroyAsObservable()
		{
			return null;
		}

		public void ForceRaiseOnDestroy()
		{
		}

		public void AddDisposableOnDestroy(IDisposable disposable)
		{
		}
	}
}
