using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableDropTrigger : ObservableTriggerBase, IEventSystemHandler, IDropHandler
	{
		private Subject<PointerEventData> onDrop;

		private void UnityEngine_002EEventSystems_002EIDropHandler_002EOnDrop(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnDropAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
