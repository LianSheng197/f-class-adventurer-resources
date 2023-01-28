using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservablePointerUpTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerUpHandler
	{
		private Subject<PointerEventData> onPointerUp;

		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerUpAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
