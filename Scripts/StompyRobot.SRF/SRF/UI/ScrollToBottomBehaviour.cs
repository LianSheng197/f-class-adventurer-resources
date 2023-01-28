using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	public class ScrollToBottomBehaviour : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private bool _scrollToTop;

		public void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void Trigger()
		{
		}

		private void OnScrollRectValueChanged(Vector2 position)
		{
		}

		private void Refresh()
		{
		}

		private void SetVisible(bool truth)
		{
		}
	}
}
