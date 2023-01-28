public class RandomSeed
{
	public enum eType
	{
		None = 0,
		KeepMark = 1,
		RandomOption = 2,
		Max = 3
	}

	public int type;

	public int _seed;

	public eType _type => default(eType);
}
