using System;

namespace Gaa
{
	[Serializable]
	public class RecurringResponse
	{
		public IapResult iapResult;

		public PurchaseData purchaseData;

		public string signature;

		public string action;

		public override string ToString()
		{
			return null;
		}
	}
}
