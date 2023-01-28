using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservablePointerEnterTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler
	{
		private Subject<PointerEventData> onPointerEnter;

		private void UnityEngine_002EEventSystems_002EIPointerEnterHandler_002EOnPointerEnter(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerEnterAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
