using System;

namespace Gaa
{
	[Serializable]
	public class ProductDetail
	{
		public string productId;

		public string type;

		public string price;

		public string priceAmountMicros;

		public string priceCurrencyCode;

		public string title;

		public override string ToString()
		{
			return null;
		}
	}
}
