public class IAPManager
{
	public enum eErrorPopup
	{
		illegal = 0,
		Failed = 1,
		RequiredUpdate = 2
	}

	private static IAPManager _instance;

	public bool _init;

	private BuyComponent.IAPDelegate _buyBtnCallBack;

	public static string _oneStorePublicKey;

	public static string _oneStorePayload;

	public static string _aosPublicKey;

	public static string _aosPayLoad;

	public static IAPManager instance => null;

	public void Init()
	{
	}

	public void BuyProduct(DesignShop.Data shop, BuyComponent.IAPDelegate callback)
	{
	}

	public void ConsumeProduct(BuyItemReq req, BuyItemAck ack, DesignShop.Data shop)
	{
	}

	public void ConsumeProductTest(string productValue)
	{
	}

	public void OnIapTest(bool isResult, IAPData iapData)
	{
	}

	public void BuyProductTest(string productValue)
	{
	}

	public void ResultInit(bool isResult, string msg = "")
	{
	}

	public void ResultBuyProduct(bool isResult, IAPData IAPData, string msg = "")
	{
	}

	public void OnError(eErrorPopup error = eErrorPopup.illegal, string msg = "")
	{
	}

	public DesignShopIAP.Data GetIAP(DesignShop.Data shop)
	{
		return null;
	}
}
