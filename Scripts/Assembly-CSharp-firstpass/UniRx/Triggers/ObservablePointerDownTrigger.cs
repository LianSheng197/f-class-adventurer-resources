using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservablePointerDownTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerDownHandler
	{
		private Subject<PointerEventData> onPointerDown;

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerDownAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
