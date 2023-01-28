using UnityEngine;

[AddComponentMenu("Popup/PopupOption")]
public class PopupOption : PopupBase
{
	public enum Filter
	{
		Game = 0,
		Account = 1
	}

	private RadioGroup _radioGroup;

	private GameObject _gameRoot;

	private GameObject _accountRoot;

	private UISlider _sleepModeTimeSlider;

	private UILabel _sleepModeTimeLabel;

	private bool _isEnableSystemSleep;

	private bool _isEnableMusic;

	private bool _isEnableSFX;

	private bool _isEnableScreenShaking;

	private bool _isEnableEffect;

	private bool _isEnableDamageFont;

	private bool _isEnablePush;

	private UIGrid _gridSignBtn;

	private Transform _btnGoogleSign;

	private Transform _btnAppleSign;

	public IntegrationReq.LoginType _integrationType;

	public string _integrationKey;

	public string _integrationLoginId;

	public void InitPopup()
	{
	}

	private void SelectFilter(string select)
	{
	}

	private void ChangeTab(Filter filter)
	{
	}

	private void SliderChange()
	{
	}

	private void EnableSystemSleep(bool enabled)
	{
	}

	private void EnableMusic(bool enabled)
	{
	}

	private void EnableSFX(bool enabled)
	{
	}

	private void EnableScreenShaking(bool enabled)
	{
	}

	private void EnableEffect(bool enabled)
	{
	}

	private void EnableDamageFont(bool enabled)
	{
	}

	private void EnablePush(bool enabled)
	{
	}

	private void UpdateInfo()
	{
	}

	private void UpdatePlatformState()
	{
	}

	private void OnAccountDelete()
	{
	}

	private void AccountDeleteWarning(GameObject obj, UIButton btn)
	{
	}

	private void AccountDeleteWarning2(GameObject obj, UIButton btn)
	{
	}

	private void AccountDeleteWarning3(GameObject obj, UIButton btn)
	{
	}

	private void OnSupport()
	{
	}

	private void ShowNotice()
	{
	}

	private void CloseOption()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void IntegrationAck(IntegrationReq req, IntegrationAck ack)
	{
	}

	private void CallBackIntergrationAccept(GameObject obj, UIButton btn)
	{
	}

	private void CallBackGoogleLogout(GameObject obj, UIButton btn)
	{
	}
}
