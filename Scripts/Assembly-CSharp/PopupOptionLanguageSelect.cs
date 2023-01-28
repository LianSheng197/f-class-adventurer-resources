using UnityEngine;

[AddComponentMenu("Popup/PopupOptionLanguageSelect")]
public class PopupOptionLanguageSelect : PopupBase
{
	private SupportLanguage.Language _selectLanguage;

	private UIGrid _grid;

	public void InitPopup()
	{
	}

	private void SelectLanguage(UIButton btn)
	{
	}

	public static string GetSupportLanguageString(SupportLanguage.Language language)
	{
		return null;
	}

	public override void Message(UIButton btn)
	{
	}
}
