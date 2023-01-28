using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservablePointerClickTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerClickHandler
	{
		private Subject<PointerEventData> onPointerClick;

		private void UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerClickAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
