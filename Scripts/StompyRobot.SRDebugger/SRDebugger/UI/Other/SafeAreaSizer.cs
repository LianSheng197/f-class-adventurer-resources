using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public class SafeAreaSizer : UIBehaviour, ILayoutElement
	{
		[SerializeField]
		[FormerlySerializedAs("Edge")]
		private RectTransform.Edge _edge;

		public float Scale;

		private float _height;

		private float _width;

		public RectTransform.Edge Edge
		{
			get
			{
				return default(RectTransform.Edge);
			}
			set
			{
			}
		}

		public float preferredWidth => 0f;

		public float preferredHeight => 0f;

		public float minWidth => 0f;

		public float minHeight => 0f;

		public int layoutPriority => 0;

		public float flexibleHeight => 0f;

		public float flexibleWidth => 0f;

		private void Refresh()
		{
		}

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}
	}
}
