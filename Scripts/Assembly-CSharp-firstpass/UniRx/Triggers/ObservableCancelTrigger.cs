using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableCancelTrigger : ObservableTriggerBase, IEventSystemHandler, ICancelHandler
	{
		private Subject<BaseEventData> onCancel;

		private void UnityEngine_002EEventSystems_002EICancelHandler_002EOnCancel(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnCancelAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
