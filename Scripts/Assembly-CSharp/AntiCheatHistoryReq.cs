public class AntiCheatHistoryReq : ReqParam
{
	public enum eType
	{
		None = 0,
		SpeedHack = 1,
		SkillLevel1 = 2,
		SkillLevel2 = 3,
		Max = 4
	}

	public int _type;

	public string _value;
}
