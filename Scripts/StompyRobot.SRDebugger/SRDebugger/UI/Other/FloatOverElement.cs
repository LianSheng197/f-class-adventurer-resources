using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class FloatOverElement : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public RectTransform CopyFrom;

		private DrivenRectTransformTracker _tracker;

		private void Copy()
		{
		}

		public void SetLayoutHorizontal()
		{
		}

		public void SetLayoutVertical()
		{
		}
	}
}
