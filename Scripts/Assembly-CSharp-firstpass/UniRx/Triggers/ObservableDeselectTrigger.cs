using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableDeselectTrigger : ObservableTriggerBase, IEventSystemHandler, IDeselectHandler
	{
		private Subject<BaseEventData> onDeselect;

		private void UnityEngine_002EEventSystems_002EIDeselectHandler_002EOnDeselect(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnDeselectAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
