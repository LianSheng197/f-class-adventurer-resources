using System;
using UnityEngine;

namespace CodeStage.AntiCheat.Common
{
	public static class ACTk
	{
		public const string Version = "2021.0.10";

		public const string LogPrefix = "[ACTk] ";

		public const string DocsRootUrl = "https://codestage.net/uas_files/actk/api/";

		internal const string SupportContact = "https://codestage.net/contacts";

		internal static readonly char[] StringKey;

		private static string unityVersion;

		private static string applicationPlatform;

		[RuntimeInitializeOnLoadMethod]
		private static void GetUnityInfo()
		{
		}

		internal static void PrintExceptionForSupport(string errorText, Exception exception = null)
		{
		}

		internal static void PrintExceptionForSupport(string errorText, string prefix = null, Exception exception = null)
		{
		}

		internal static string ConstructErrorForSupport(string text, string prefix = null, Exception exception = null)
		{
			return null;
		}

		internal static string GenerateBugReport(Exception exception = null)
		{
			return null;
		}
	}
}
