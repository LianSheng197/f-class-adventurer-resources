using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableSelectTrigger : ObservableTriggerBase, IEventSystemHandler, ISelectHandler
	{
		private Subject<BaseEventData> onSelect;

		private void UnityEngine_002EEventSystems_002EISelectHandler_002EOnSelect(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnSelectAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
