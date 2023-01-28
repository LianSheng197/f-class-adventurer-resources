using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class UnityIapHandler : MonoBehaviour, IStoreListener
{
	public class PurchaseData
	{
		public string data;

		public string token;

		public string orderId;

		public string productId;

		public PurchaseData()
		{
		}

		public PurchaseData(string purchaseData)
		{
		}
	}

	private static IStoreController m_StoreController;

	private static IExtensionProvider m_StoreExtensionProvider;

	private List<DesignShopIAP.Data> _designShopIapList;

	private Dictionary<string, string> _iapPriceList;

	private static UnityIapHandler _instance;

	private Dictionary<string, IAPData> _pendingDataList;

	public static UnityIapHandler GetInstance()
	{
		return null;
	}

	private void Start()
	{
	}

	public void InitializePurchasing(List<DesignShopIAP.Data> designShopIapList)
	{
	}

	private void InitIapList()
	{
	}

	public void SetIapPrice()
	{
	}

	public Product GetProduct(string product_id)
	{
		return null;
	}

	public string GetPrice(string product_id)
	{
		return null;
	}

	private bool IsInitialized()
	{
		return false;
	}

	public void BuyProductID(string productId)
	{
	}

	public void RestoreProductID(List<DesignShopIAP.Data> designShopIapList)
	{
	}

	public void finishCompletedTransactions(string productId)
	{
	}

	public void RestorePurchases()
	{
	}

	private void InitGoogleData()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	private string ParseAppleReceipt(string receipt)
	{
		return null;
	}

	private void ParseGooglePlayReceipt(string receipt, out string purchaseData, out string dataSignature)
	{
		purchaseData = null;
		dataSignature = null;
	}
}
