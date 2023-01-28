using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableEndDragTrigger : ObservableTriggerBase, IEventSystemHandler, IEndDragHandler
	{
		private Subject<PointerEventData> onEndDrag;

		private void UnityEngine_002EEventSystems_002EIEndDragHandler_002EOnEndDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnEndDragAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
