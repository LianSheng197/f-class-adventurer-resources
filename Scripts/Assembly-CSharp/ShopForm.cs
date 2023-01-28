using UnityEngine;

public class ShopForm : MonoBehaviour
{
	public DesignShopCategory.Data _data;

	private UISprite _sprite;

	public virtual void init(DesignShopCategory.Data data)
	{
	}

	public virtual void init()
	{
	}

	public virtual void SetTitle()
	{
	}

	public virtual void DownloadBackgroundImg()
	{
	}

	public virtual void UpdateUI()
	{
	}

	public virtual void SetBackgroundSize()
	{
	}

	public Vector3 GetSize()
	{
		return default(Vector3);
	}

	private void OnDestroy()
	{
	}
}
