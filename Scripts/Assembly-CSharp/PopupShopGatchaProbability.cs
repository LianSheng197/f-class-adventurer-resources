using UnityEngine;

[AddComponentMenu("Popup/PopupShopGatchaProbability")]
public class PopupShopGatchaProbability : PopupBase
{
	private class stData
	{
		public int _id;

		public int _seed;

		public int _lastSeed;

		public int _type;

		public int _count;
	}

	private GachaGroup _GachaGroup;

	public void InitPopup(GachaGroup GachaGroup)
	{
	}

	private void InitStepUp()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
