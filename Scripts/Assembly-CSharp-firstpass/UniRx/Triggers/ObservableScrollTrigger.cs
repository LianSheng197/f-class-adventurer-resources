using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableScrollTrigger : ObservableTriggerBase, IEventSystemHandler, IScrollHandler
	{
		private Subject<PointerEventData> onScroll;

		private void UnityEngine_002EEventSystems_002EIScrollHandler_002EOnScroll(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnScrollAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
