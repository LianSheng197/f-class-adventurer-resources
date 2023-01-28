using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Copy Size Into Layout Element")]
	public class CopySizeIntoLayoutElement : LayoutElement
	{
		public RectTransform CopySource;

		public float PaddingHeight;

		public float PaddingWidth;

		public bool SetPreferredSize;

		public bool SetMinimumSize;

		public override float preferredWidth => 0f;

		public override float preferredHeight => 0f;

		public override float minWidth => 0f;

		public override float minHeight => 0f;

		public override int layoutPriority => 0;
	}
}
