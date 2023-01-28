using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/MsgBox")]
public class MsgBox : MonoBehaviour
{
	public delegate void PopupMessage(GameObject obj, UIButton btn);

	public enum MSGBOXTYPE
	{
		None = 0,
		MsgBox_One = 1,
		MsgBox_Two = 2,
		MsgBox_One_Big = 3,
		Max = 4
	}

	public enum PopupAnimation
	{
		None = 0,
		Ani_PopupMiddleSize_Open = 1,
		Max = 2
	}

	private const int BaseDepth = 80000;

	private static MsgBox _instance;

	private Texture2D _backgroundTexture;

	private Dictionary<PopupAnimation, AnimationClip> _animationList;

	public Dictionary<GameObject, PopupMessage> _delegateList;

	public List<GameObject> _msgList;

	public static MsgBox Instance => null;

	private void InitMsgBox()
	{
	}

	private void LoadPopupAnimation()
	{
	}

	public GameObject Show(MSGBOXTYPE popup, int languageID)
	{
		return null;
	}

	public GameObject Show(MSGBOXTYPE popup, string msg)
	{
		return null;
	}

	public GameObject Show(MSGBOXTYPE popup, int languageID, PopupMessage callBack)
	{
		return null;
	}

	public GameObject Show(MSGBOXTYPE popup, string msg, PopupMessage callBack)
	{
		return null;
	}

	public void ChangeDepth(GameObject popup, int depth)
	{
	}

	public void ChangeNotice(GameObject popup, int languageID)
	{
	}

	public bool CheckOpenPopup()
	{
		return false;
	}

	public int CheckOpenPopupCount()
	{
		return 0;
	}

	public bool CloseTopMsg()
	{
		return false;
	}

	public void Close(GameObject popup)
	{
	}

	private void SetupPopupAnimation(GameObject popupObj)
	{
	}

	private void SetupInteraction(GameObject popupObj)
	{
	}

	public int GetNextPopupDepth()
	{
		return 0;
	}

	private void Message(GameObject obj, UIButton btn)
	{
	}

	public bool IsMsgBoxOpen()
	{
		return false;
	}
}
