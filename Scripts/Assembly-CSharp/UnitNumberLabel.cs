using System.Text;
using UnityEngine;

public class UnitNumberLabel : MonoBehaviour
{
	private enum UnitStyle
	{
		Normal = 0,
		Dot = 1
	}

	private const UnitStyle _unitStyle = UnitStyle.Dot;

	private DesignStandardTime.Data _designStandardTime;

	private UILabel _label;

	private static StringBuilder _sb;

	private string _prevNumber;

	public static string ConvertUnitText(long number)
	{
		return null;
	}

	public static string ConvertUnitText(string number)
	{
		return null;
	}

	public static string ConvertUnitText(decimal number)
	{
		return null;
	}

	public static string ConvertUnitText(double number)
	{
		return null;
	}

	public void Init(SupportLanguage.Language language)
	{
	}

	public static string Calc(DesignStandardTime.Data designStandardTime, string numberOrign)
	{
		return null;
	}

	public void UpdateText(string numberString)
	{
	}
}
