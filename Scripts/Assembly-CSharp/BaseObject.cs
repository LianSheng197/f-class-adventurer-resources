using System;

[Serializable]
public class BaseObject
{
	public long _idx;

	public int _designId;

	public long _count;

	public int _enchantLevel;

	public int _grade;

	public bool _isNew;

	public bool _isLock;

	public void Copy(ref BaseObject data)
	{
	}

	public BaseObject Copy()
	{
		return null;
	}

	public virtual string GetName()
	{
		return null;
	}

	public virtual int GetGrade()
	{
		return 0;
	}
}
