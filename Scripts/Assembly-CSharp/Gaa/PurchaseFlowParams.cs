using System;

namespace Gaa
{
	[Serializable]
	public class PurchaseFlowParams
	{
		public string productId;

		public string productType;

		public string productName;

		public string devPayload;

		public string gameUserId;

		public bool promotionApplicable;
	}
}
