using System.Collections.Generic;

public class AltarManager
{
	private static AltarManager _Instance;

	private AltarData _altarData;

	private List<ContentsFunctionData> _emptyContentsFunctionData;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static AltarManager Instance => null;

	public void Set(AltarData data)
	{
	}

	public AltarData Get()
	{
		return null;
	}

	public DesignAltar.Data GetDesignAltar()
	{
		return null;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}
}
