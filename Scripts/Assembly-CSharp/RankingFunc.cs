using System;

public class RankingFunc
{
	[Serializable]
	public class RankingDataBase
	{
		public int _rank;

		public int _userId;

		public int _point;

		public string _name;
	}

	[Serializable]
	public class RankingDataWithUserName : RankingDataBase
	{
		public string _userName;
	}

	[Serializable]
	public class RankingDataWithoutUserName : RankingDataBase
	{
	}

	[Serializable]
	public class RankingTower : RankingDataWithUserName
	{
	}
}
