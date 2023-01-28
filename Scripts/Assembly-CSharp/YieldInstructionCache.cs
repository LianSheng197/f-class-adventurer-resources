using System.Collections.Generic;
using UnityEngine;

internal static class YieldInstructionCache
{
	public static readonly WaitForEndOfFrame WaitForEndOfFrame;

	public static readonly WaitForFixedUpdate WaitForFixedUpdate;

	private static readonly Dictionary<float, WaitForSeconds> waitForSeconds;

	public static WaitForSeconds WaitForSeconds(float seconds)
	{
		return null;
	}
}
