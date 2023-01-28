using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableEventTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IInitializePotentialDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		private Subject<BaseEventData> onDeselect;

		private Subject<AxisEventData> onMove;

		private Subject<PointerEventData> onPointerDown;

		private Subject<PointerEventData> onPointerEnter;

		private Subject<PointerEventData> onPointerExit;

		private Subject<PointerEventData> onPointerUp;

		private Subject<BaseEventData> onSelect;

		private Subject<PointerEventData> onPointerClick;

		private Subject<BaseEventData> onSubmit;

		private Subject<PointerEventData> onDrag;

		private Subject<PointerEventData> onBeginDrag;

		private Subject<PointerEventData> onEndDrag;

		private Subject<PointerEventData> onDrop;

		private Subject<BaseEventData> onUpdateSelected;

		private Subject<PointerEventData> onInitializePotentialDrag;

		private Subject<BaseEventData> onCancel;

		private Subject<PointerEventData> onScroll;

		private void UnityEngine_002EEventSystems_002EIDeselectHandler_002EOnDeselect(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnDeselectAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIMoveHandler_002EOnMove(AxisEventData eventData)
		{
		}

		public IObservable<AxisEventData> OnMoveAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerDownAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerEnterHandler_002EOnPointerEnter(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerEnterAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerExitHandler_002EOnPointerExit(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerExitAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerUpAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EISelectHandler_002EOnSelect(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnSelectAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnPointerClickAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EISubmitHandler_002EOnSubmit(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnSubmitAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnDragAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIBeginDragHandler_002EOnBeginDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnBeginDragAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIEndDragHandler_002EOnEndDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnEndDragAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIDropHandler_002EOnDrop(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnDropAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIUpdateSelectedHandler_002EOnUpdateSelected(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnUpdateSelectedAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EIInitializePotentialDragHandler_002EOnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public IObservable<PointerEventData> OnInitializePotentialDragAsObservable()
		{
			return null;
		}

		private void UnityEngine_002EEventSystems_002EICancelHandler_002EOnCancel(BaseEventData eventData)
		{
		}

		public IObservable<BaseEventData> OnCancelAsObservable()
		{
			return null;
		}

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
