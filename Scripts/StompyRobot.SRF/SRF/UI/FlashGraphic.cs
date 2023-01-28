using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Flash Graphic")]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public float DecayTime;

		public Color DefaultColor;

		public Color FlashColor;

		public Graphic Target;

		private bool _isHoldingUntilNextPress;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		protected override void OnEnable()
		{
		}

		public void Flash()
		{
		}

		public void FlashAndHoldUntilNextPress()
		{
		}
	}
}
