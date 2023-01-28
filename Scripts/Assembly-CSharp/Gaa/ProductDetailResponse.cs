using System;

namespace Gaa
{
	[Serializable]
	public class ProductDetailResponse
	{
		public IapResult iapResult;

		public ProductDetail productDetail;

		public int count;

		public int totalCount;

		public override string ToString()
		{
			return null;
		}
	}
}
