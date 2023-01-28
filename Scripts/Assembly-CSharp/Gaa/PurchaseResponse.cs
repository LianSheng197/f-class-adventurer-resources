using System;

namespace Gaa
{
	[Serializable]
	public class PurchaseResponse
	{
		public IapResult iapResult;

		public PurchaseData purchaseData;

		public string signature;

		public int count;

		public int totalCount;

		public override string ToString()
		{
			return null;
		}
	}
}
