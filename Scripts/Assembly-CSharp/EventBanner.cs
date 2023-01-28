using System;
using System.Collections.Generic;

[Serializable]
public class EventBanner : EventList
{
	[Serializable]
	public class Data : EventListData
	{
		public enum linkType
		{
			none = 0,
			open_helpshift = 1,
			open_popup = 2,
			open_shopPopup = 3,
			open_shopCategory = 4,
			open_eknotice = 5,
			open_naverSdk = 6,
			open_naverLounge = 7,
			open_naverLoungeBoard = 8,
			size = 9
		}

		[Serializable]
		public class buttonData
		{
			public string _linkType;

			public string _linkValue;

			public int _buttonLangId;
		}

		public int _idx;

		public DateTime _bannerStartTime;

		public int _openStage;

		public List<buttonData> _buttonList;
	}

	public override bool IsActive()
	{
		return false;
	}

	public override bool CheckNew()
	{
		return false;
	}
}
