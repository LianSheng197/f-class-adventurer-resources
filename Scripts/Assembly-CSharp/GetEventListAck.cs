using System;
using System.Collections.Generic;

public class GetEventListAck : AckParam
{
	[Serializable]
	public class ConvertJsonData
	{
		public List<EventBanner> _listEventBanner;

		public List<EventBanner.Data> _listEventBannerData;

		public List<EventLogin> _listEventLogin;

		public List<EventLogin.Data> _listEventLoginData;

		public List<EventLoginUserData> _listEventLoginUserData;

		public List<EventTeamLevel> _listEventTeamLevel;

		public List<EventTeamLevel.Data> _listEventTeamLevelData;

		public List<EventTeamLevelUserData> _listEventTeameLevelUpUserData;

		public List<EventAccess> _listEventAccess;

		public List<EventAccess.Data> _listEventAccessData;

		public List<EventAccessUserData> _listEventAccessUserData;

		public List<EventRandomBox> _listEventRandomBox;

		public List<EventRandomBox.Data> _listEventRandomBoxData;

		public List<EventRandomBoxUserData> _listEventRandomBoxUserData;
	}

	public string _strList;
}
