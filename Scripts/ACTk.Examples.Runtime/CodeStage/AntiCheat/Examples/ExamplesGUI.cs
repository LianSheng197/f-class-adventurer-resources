using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	[AddComponentMenu(null)]
	internal class ExamplesGUI : MonoBehaviour
	{
		private enum ExamplePage
		{
			ObscuredTypes = 0,
			SavesProtection = 1,
			Detectors = 2,
			CodeHashing = 3
		}

		internal const string RedColor = "#FF4040";

		internal const string YellowColor = "#E9D604";

		internal const string GreenColor = "#02C85F";

		internal const string BlueColor = "#75C4EB";

		internal static GUIStyle centeredStyle;

		private ObscuredTypesExamples obscuredTypesExamples;

		private ObscuredPrefsExamples obscuredPrefsExamples;

		private ObscuredFilePrefsExamples obscuredFilePrefsExamples;

		private DetectorsExamples detectorsExamples;

		private CodeHashExamples codeHashExamples;

		private readonly string[] tabs;

		private readonly string[] savesTabs;

		private ExamplePage currentPage;

		private int savesPage;

		public DetectorsExamples DetectorsExamples => null;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		private void DrawSavesProtectionPage()
		{
		}

		internal static string Colorize(string stringToWrap, bool green)
		{
			return null;
		}

		private static string Colorize(string stringToWrap, string color)
		{
			return null;
		}

		private static string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}
	}
}
