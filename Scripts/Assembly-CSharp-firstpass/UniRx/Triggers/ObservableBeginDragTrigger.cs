using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableBeginDragTrigger : ObservableTriggerBase, IEventSystemHandler, IBeginDragHandler
	{
		private Subject<PointerEventData> onBeginDrag;

		private void UnityEngine_002EEventSystems_002EIBeginDragHandler_002EOnBeginDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnBeginDragAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
