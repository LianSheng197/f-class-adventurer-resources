using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableInitializePotentialDragTrigger : ObservableTriggerBase, IEventSystemHandler, IInitializePotentialDragHandler
	{
		private Subject<PointerEventData> onInitializePotentialDrag;

		private void UnityEngine_002EEventSystems_002EIInitializePotentialDragHandler_002EOnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnInitializePotentialDragAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
