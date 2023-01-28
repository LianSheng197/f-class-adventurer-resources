using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableMoveTrigger : ObservableTriggerBase, IEventSystemHandler, IMoveHandler
	{
		private Subject<AxisEventData> onMove;

		private void UnityEngine_002EEventSystems_002EIMoveHandler_002EOnMove(AxisEventData eventData)
		{
		}

		public IObservable<AxisEventData> OnMoveAsObservable()
		{
			return null;
		}

		protected override void RaiseOnCompletedOnDestroy()
		{
		}
	}
}
