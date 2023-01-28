using System.Collections.Generic;

public class ContentsFunction
{
	public static List<ContentsFunctionData> _useList;

	private static DesignContentsFunction _designCF;

	private static DesignSkill _designS;

	private static DesignCharacterSkill _designCS;

	private static DesignUpgrade _designDU;

	public static List<ContentsFunctionData> GetContentsFunctionList(Character character, int functionType)
	{
		return null;
	}

	public static double GetContentsFunctionMultiply(DesignContentsFunction.Data.FunctionType functionType, int compareValue, Character character)
	{
		return 0.0;
	}

	public static double GetValue(DesignContentsFunction.Data.FunctionType functionType, double baseValue, Character character, int compareValue, DesignStage.Data designStage, Character target)
	{
		return 0.0;
	}

	public static double GetValueCustomCondition(DesignContentsFunction.Data.FunctionType functionType, double baseValue, Character character, int compareValue)
	{
		return 0.0;
	}

	public static bool Check(ContentsFunctionData function, int compareValue, Character character, DesignStage.Data designStage, Character target)
	{
		return false;
	}

	public static double GetValue(Character character, DesignContentsFunction.Data.FunctionType functionType, double baseValue, DesignContentsFunction.Data.FunctionTargetType targetType, int conditionValue)
	{
		return 0.0;
	}

	public static double GetContinualHitValue(double baseValue, int hitCount)
	{
		return 0.0;
	}

	public static double GetHPPercentDamageValue(DesignContentsFunction.Data.FunctionType functionType, double damage, double hp)
	{
		return 0.0;
	}

	public static double GetEmergencyDamageValue(double damage, double hp, double maxHp)
	{
		return 0.0;
	}

	public static double GetMaximumDamageValue(double damage, double hp)
	{
		return 0.0;
	}

	public static bool IsBlock(double damage, double hp)
	{
		return false;
	}

	public static bool IsAvoid(double damage, double hp)
	{
		return false;
	}
}
