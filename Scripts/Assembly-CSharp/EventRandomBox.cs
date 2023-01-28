using System;
using System.Collections.Generic;

[Serializable]
public class EventRandomBox : EventList
{
	[Serializable]
	public class Data : EventListData
	{
		public enum LIMITED_TYPE
		{
			Account = 0,
			Dailiy = 1,
			Weekly = 2,
			Monthly = 3,
			Unlimited = 99,
			Size = 100
		}

		[Serializable]
		public class needItemType
		{
			public int _itemId;

			public int _itemCount;
		}

		[Serializable]
		public class gachaItem
		{
			public int _itemId;

			public int _itemCount;

			public int _seed;
		}

		public int _idx;

		public int _eventGroupId;

		public LIMITED_TYPE _limitedType;

		public int _mailId;

		public string _boxFolder;

		public string _boxAtlas;

		public string _boxImage;

		public List<needItemType> _needItemTypeList;

		public List<gachaItem> _itemTypeList;

		public bool IsSoldOut(EventRandomBoxUserData userData, ref bool IsRecover)
		{
			return false;
		}
	}

	public override bool IsActive()
	{
		return false;
	}

	public override void SetRead()
	{
	}

	public override bool CheckNew()
	{
		return false;
	}
}
