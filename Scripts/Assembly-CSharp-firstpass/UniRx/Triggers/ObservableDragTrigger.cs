using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableDragTrigger : ObservableTriggerBase, IEventSystemHandler, IDragHandler
	{
		private Subject<PointerEventData> onDrag;

		private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnDragAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
