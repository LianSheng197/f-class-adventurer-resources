using UnityEngine;

public class LoginScene : SceneBase
{
	private GameObject _login;

	private GameObject _loginBtn;

	private GameObject _createBtn;

	private UILabel _guestId;

	public UILabel _loginState;

	public static bool _isDebug;

	private bool _isPossibleLogin;

	private GameObject _popupPatch;

	public override void InitScene()
	{
	}

	public override void EnterScene()
	{
	}

	private void EndEnvironment(bool isResult, string strResult)
	{
	}

	private void EndParticialConnectConfig(bool isResult, string strResult)
	{
	}

	private void EndAssetBundleCRCConfig(bool isResult, string strResult)
	{
	}

	private void EndConnectConfig(bool isResult, string strResult)
	{
	}

	public void FailedEnvironment(GameObject obj, UIButton btn)
	{
	}

	private void SetConnectInfo()
	{
	}

	private void SuccessFacebookInit()
	{
	}

	private void CheckClientVersion()
	{
	}

	private void CheckPatch()
	{
	}

	public static string GetTargetPlatformDownLoadURL()
	{
		return null;
	}

	public static string GetPatchBaseDownLoadURL()
	{
		return null;
	}

	private void callBackPatch(PatchManager.PATCH_STATE state)
	{
	}

	private void ForceUpdatePatch()
	{
	}

	public void GotoUpdatePatch(GameObject obj, UIButton btn)
	{
	}

	public void FailedPatch(GameObject obj, UIButton btn)
	{
	}

	private void PreLoadAssetBundle()
	{
	}

	private void DataLoad()
	{
	}

	private void CheckMainternance()
	{
	}

	private void CheckPolicyAgree()
	{
	}

	private void StartLogin()
	{
	}

	private void Message(UIButton btn)
	{
	}

	public void MoveDownLoadPage(GameObject obj, UIButton btn)
	{
	}

	public void callCreate(GameObject obj, UIButton btn)
	{
	}

	public void OnMainternance(GameObject obj, UIButton btn)
	{
	}

	public static void ChangeStateLabel(int languageID)
	{
	}

	public override bool AndroidBackButton()
	{
		return false;
	}

	public override void InitSceneStart()
	{
	}

	public override void InitSceneEnd()
	{
	}

	public override void EnterSceneStart()
	{
	}

	public override void EnterSceneEnd()
	{
	}
}
