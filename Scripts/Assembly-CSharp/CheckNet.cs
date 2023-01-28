using System.Collections.Generic;
using UnityEngine;

public class CheckNet : MonoBehaviour
{
	public delegate void CallBack(bool isResult, CheckNetObj obj);

	public delegate void AvailableCallBack(bool isResult);

	private string _pingAddress;

	private bool _bIndicator;

	private bool _bMsgBox;

	private List<CheckNetObj> _objList;

	private CheckNetObj _retryObj;

	public void init()
	{
	}

	public void StartPing(bool bIndicator, bool bMsxBox, short count, AvailableCallBack callBack = null)
	{
	}

	private void pingCallBack(bool isResult, CheckNetObj obj)
	{
	}

	private void OnRetryCallBack(GameObject obj, UIButton btn)
	{
	}

	private void CreateIndicator()
	{
	}

	private void RemoveIndicator()
	{
	}
}
