using System.Collections.Generic;

public class GameData
{
	private Dictionary<int, ClientSave> _clientSave;

	public void ClearClientSave()
	{
	}

	public void SetClientSave(List<ClientSave> saves, bool isClear)
	{
	}

	public void SetClientSave(ClientSave save)
	{
	}

	public List<int> GetStageRandomRewardDouble()
	{
		return null;
	}

	public static List<int> ParseStageRandomRewardDouble(string prevValue)
	{
		return null;
	}

	public void SetClientSaveStageRandomRewardDouble(int randomRewardType)
	{
	}

	public string GetClientSave(int saveType)
	{
		return null;
	}

	public string GetClientSave(ClientSave.eType saveType)
	{
		return null;
	}

	public T GetClientSave<T>(ClientSave.eType saveType, T defaultValue = default(T))
	{
		return default(T);
	}

	public ClientSave GetClientSaveData(int saveType)
	{
		return null;
	}

	public ClientSave GetClientSaveData(ClientSave.eType saveType)
	{
		return null;
	}

	public void RemoveClientSave(int saveType)
	{
	}

	public List<int> GetAllScenario()
	{
		return null;
	}

	public bool IsClientSave(int saveType)
	{
		return false;
	}

	public bool IsClientSave(ClientSave.eType saveType)
	{
		return false;
	}

	public void SendClientSave(ClientSave.eType saveType, string saveValue = "1", bool isForce = false)
	{
	}

	public void SendClientSave(int saveType, string saveValue = "1", bool isForce = false)
	{
	}

	public void SendClientSave(List<ClientSave> clientSaves, bool isForce)
	{
	}
}
