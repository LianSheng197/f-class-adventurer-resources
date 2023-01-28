using System.Collections.Generic;

public class RecvStorageReq : ReqParam
{
	public Storage.eType _type;

	public List<Storage> _listData;

	public string _userName;

	public int _selectItemId;
}
