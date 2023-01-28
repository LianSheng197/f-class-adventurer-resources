using UnityEngine;

[AddComponentMenu("Popup/PopupMail")]
public class PopupMail : PopupBase
{
	public delegate void RecvCallBack();

	private const int _ViewCount = 6;

	private StorageInven _curStorage;

	private Storage.eType _curType;

	private UIGrid _curGrid;

	private GameObject _gridBG;

	private Transform _rewardAllForm;

	private int _curPage;

	public void InitPopup()
	{
	}

	public void UpdateUI()
	{
	}

	private void UpdateList()
	{
	}

	private void SetStorage(Storage.eType t)
	{
	}

	private void NextPage()
	{
	}

	private void PrevPage()
	{
	}

	private int GetLastPage()
	{
		return 0;
	}

	public override void Message(UIButton btn)
	{
	}

	private void SendAllRecv(UIButton btn)
	{
	}

	public void WWWRecvStorageAllResult(WWWRecvStorage www)
	{
	}

	public void WWWGetStorageResult(WWWGetStorage www)
	{
	}

	public override void PopupCloseCall()
	{
	}

	public void LockRecvButtonList(WWWRecvStorage www)
	{
	}
}
