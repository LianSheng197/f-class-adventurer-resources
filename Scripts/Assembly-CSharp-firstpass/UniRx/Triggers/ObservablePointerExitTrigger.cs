using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservablePointerExitTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerExitHandler
	{
		private Subject<PointerEventData> onPointerExit;

		private void UnityEngine_002EEventSystems_002EIPointerExitHandler_002EOnPointerExit(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerExitAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
