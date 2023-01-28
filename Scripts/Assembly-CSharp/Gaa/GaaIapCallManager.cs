using UnityEngine;

namespace Gaa
{
	public class GaaIapCallManager
	{
		private static string TAG;

		private static AndroidJavaObject iapRequestAdapter;

		private static AndroidJavaClass jc;

		private static bool isServiceCreated;

		private static void ServiceAvailableEvent(bool value)
		{
		}

		public static bool IsServiceAvailable()
		{
			return false;
		}

		public static bool CheckServiceAvailable()
		{
			return false;
		}

		static GaaIapCallManager()
		{
		}

		~GaaIapCallManager()
		{
		}

		public static void StartConnection(string publicKey)
		{
		}

		public static void QueryPurchases(string type)
		{
		}

		public static void QueryProductDetails(string[] products, string productType)
		{
		}

		public static void LaunchPurchaseFlow(PurchaseFlowParams param)
		{
		}

		public static void Consume(PurchaseData purchaseData, string devPayload)
		{
		}

		public static void Acknowledge(PurchaseData purchaseData, string devPayload)
		{
		}

		public static void ManageRecurringProduct(PurchaseData purchaseData, string recurringAction)
		{
		}

		public static void LaunchUpdateOrInstallFlow()
		{
		}

		public static void LaunchLoginFlow()
		{
		}

		public static void GetStoreInfo()
		{
		}

		public static void Destroy()
		{
		}
	}
}
