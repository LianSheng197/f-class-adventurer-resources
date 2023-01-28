using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableUpdateSelectedTrigger : ObservableTriggerBase, IEventSystemHandler, IUpdateSelectedHandler
	{
		private Subject<BaseEventData> onUpdateSelected;

		private void UnityEngine_002EEventSystems_002EIUpdateSelectedHandler_002EOnUpdateSelected(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnUpdateSelectedAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
