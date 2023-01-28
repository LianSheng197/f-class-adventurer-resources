using UnityEngine;

public class AndroidBilling : MonoBehaviour
{
	private string _strPublicKey;

	private string _strPayLoad;

	public bool init;

	private static AndroidBilling _instance;

	private static AndroidJavaObject _curActivity;

	public static AndroidBilling GetInstance()
	{
		return null;
	}

	private void CallJavaFunc(string strFuncName, params object[] param)
	{
	}

	public void InAppInit(string strPublicKey, string strPayLoad)
	{
	}

	public void InAppBuyItem(string strItemId)
	{
	}

	public void finishCompletedTransactions(string strProductId)
	{
	}
}
