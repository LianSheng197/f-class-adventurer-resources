using UnityEngine;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableRectTransformTrigger : ObservableTriggerBase
	{
		private Subject<Unit> onRectTransformDimensionsChange;

		private Subject<Unit> onRectTransformRemoved;

		public void OnRectTransformDimensionsChange()
		{
		}

		public IObservable<Unit> OnRectTransformDimensionsChangeAsObservable()
		{
			return null;
		}

		public void OnRectTransformRemoved()
		{
		}

		public IObservable<Unit> OnRectTransformRemovedAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
