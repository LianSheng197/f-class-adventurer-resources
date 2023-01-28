using System.Collections.Generic;
using UnityEngine;

public class RadioGroup : MonoBehaviour
{
	public delegate void SelectDelegate(string name);

	public delegate bool CheckDelegate(string name);

	private SelectDelegate _selectDelegate;

	public CheckDelegate _checkDelegate;

	private Dictionary<string, Transform> _radioStringList;

	private Dictionary<int, Transform> _radioIndexList;

	public string _curSelect;

	public void Init(int firstIndex, SelectDelegate selectDelegate, bool isImmediate = false, bool defaultSelect = true)
	{
	}

	public void Init(string firstName, SelectDelegate selectDelegate, bool isImmediate = false, bool defaultSelect = true)
	{
	}

	public void FixMenu(string name)
	{
	}

	public void ReleaseFixFilter()
	{
	}

	public void ManualSelect(string name, bool isImmediate = false)
	{
	}

	public void ManualSelectMenu(string name)
	{
	}

	private void Select()
	{
	}

	private void Message(UIButton btn)
	{
	}
}
