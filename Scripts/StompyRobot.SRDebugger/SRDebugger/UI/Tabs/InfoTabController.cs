using System.Collections.Generic;
using SRDebugger.UI.Controls;
using SRF;
using SRF.UI;
using UnityEngine;

namespace SRDebugger.UI.Tabs
{
	public class InfoTabController : SRMonoBehaviourEx
	{
		public const char Tick = '✓';

		public const char Cross = '×';

		public const string NameColor = "#BCBCBC";

		private Dictionary<string, InfoBlock> _infoBlocks;

		[RequiredField]
		public InfoBlock InfoBlockPrefab;

		[RequiredField]
		public RectTransform LayoutContainer;

		[RequiredField]
		public FlashGraphic ToggleButton;

		private bool _updateEveryFrame;

		protected override void OnEnable()
		{
		}

		public void Refresh()
		{
		}

		protected override void Update()
		{
		}

		public void ActivateRefreshEveryFrame()
		{
		}

		private void InternalRefresh()
		{
		}

		private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info)
		{
		}

		private InfoBlock CreateBlock(string title)
		{
			return null;
		}
	}
}
