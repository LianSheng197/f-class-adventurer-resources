using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableSubmitTrigger : ObservableTriggerBase, IEventSystemHandler, ISubmitHandler
	{
		private Subject<BaseEventData> onSubmit;

		private void UnityEngine_002EEventSystems_002EISubmitHandler_002EOnSubmit(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnSubmitAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
