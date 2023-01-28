public class BuyItemReq : ReqParam
{
	public DesignShop.Data.BuyType _buyType;

	public IAPData _iap;

	public bool _isRestore;

	public int _shopId;

	public int _buyCount;

	public bool _IsInstant;

	public int _categoryGroup;
}
