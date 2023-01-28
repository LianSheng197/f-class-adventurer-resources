using System;

[Serializable]
public class Item : BaseObject
{
	[NonSerialized]
	private DesignItem.Data _designData;

	public void Copy(ref Item data)
	{
	}

	public new Item Copy()
	{
		return null;
	}

	public DesignItem.Data GetDesignItem()
	{
		return null;
	}

	public DesignItemGrade.Data GetDesignItemGrade()
	{
		return null;
	}

	public DesignItemSubGrade.Data GetDesignItemSubGrade()
	{
		return null;
	}

	public override string GetName()
	{
		return null;
	}

	public virtual string GetDescription()
	{
		return null;
	}
}
