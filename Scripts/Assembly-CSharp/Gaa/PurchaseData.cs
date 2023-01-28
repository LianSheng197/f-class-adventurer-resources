using System;

namespace Gaa
{
	[Serializable]
	public class PurchaseData
	{
		public string orderId;

		public string packageName;

		public string productId;

		public long purchaseTime;

		public string purchaseId;

		public string purchaseToken;

		public string developerPayload;

		public int purchaseState;

		public int recurringState;

		public int acknowledgeState;

		public bool IsAcknowledged()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
