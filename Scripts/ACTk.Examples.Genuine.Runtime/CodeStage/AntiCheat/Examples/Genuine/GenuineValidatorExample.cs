using CodeStage.AntiCheat.Genuine.CodeHash;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples.Genuine
{
	public class GenuineValidatorExample : MonoBehaviour
	{
		public const string Separator = "\ud83d\udc96";

		public const string FileName = "Textures.asset";

		public static readonly char[] StringKey;

		private string status;

		public static string GetHash(string firstBuildHash)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		private void OnCheckHashClick()
		{
		}

		private void OnGotHash(HashGeneratorResult result)
		{
		}

		public static char[] BytesToUnicodeChars(byte[] input)
		{
			return null;
		}

		public static byte[] UnicodeCharsToBytes(char[] input)
		{
			return null;
		}
	}
}
