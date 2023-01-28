using UnityEngine;

public class BuyComponent : MonoBehaviour
{
	public delegate void IAPDelegate(bool isResult, IAPData iapData);

	private DesignShop.Data _data;

	public static bool _isLock;

	private bool _isShowAds;

	public static void Lock()
	{
	}

	public static void UnLock()
	{
	}

	public void init(DesignShop.Data data)
	{
	}

	public void Select()
	{
	}

	private void DownLoadEnvironment()
	{
	}

	private void EndEnvironment(bool isResult, string strResult)
	{
	}

	public bool Buy(int count)
	{
		return false;
	}

	private void WWWBuyCallBack(WWWData ack)
	{
	}

	public void BuyByIAP(bool isResult, IAPData iapData)
	{
	}

	public void AdsCallBack(AdsIntegration.eState state)
	{
	}

	private void BuyByAds(GameObject popupObj, UIButton btn)
	{
	}

	public static bool Check(DesignShop.Data data, int count, bool IsMsgBox, MsgBox.PopupMessage callBack)
	{
		return false;
	}

	public static bool CheckConsume(DesignShop.Data data, int count, bool IsMsgBox, MsgBox.PopupMessage callBack)
	{
		return false;
	}

	public static bool CheckCondition(DesignShop.Data data, int count, bool IsMsgBox)
	{
		return false;
	}

	public void GoShop(GameObject obj, UIButton btn)
	{
	}
}
