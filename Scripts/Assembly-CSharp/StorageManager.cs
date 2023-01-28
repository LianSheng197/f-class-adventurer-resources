using System.Collections.Generic;

public class StorageManager
{
	private static StorageManager _Instance;

	public Dictionary<Storage.eType, StorageInven> _dic;

	public static StorageManager Instance => null;

	public StorageInven GetStorage(Storage.eType t)
	{
		return null;
	}

	public void ClearStorage()
	{
	}

	public bool isNewAll()
	{
		return false;
	}

	public bool IsNew(Storage.eType type)
	{
		return false;
	}

	public long GetReadIndex(Storage.eType type)
	{
		return 0L;
	}

	public void SetReadIndex(Storage.eType type)
	{
	}
}
