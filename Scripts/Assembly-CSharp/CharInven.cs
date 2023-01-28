public class CharInven : Inven<Character>
{
	public enum ConditionType
	{
		Attribute = 0,
		Nation = 1,
		Fame = 2,
		Max = 3
	}

	public override void Add(long idx, Character data)
	{
	}

	public int GetCount(ConditionType type, int val)
	{
		return 0;
	}

	public CharInven()
	{
		((Inven<>)(object)this)._002Ector();
	}
}
