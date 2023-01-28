using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Genuine.CodeHash;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	internal class CodeHashExamples : MonoBehaviour
	{
		public string savedSummaryHash;

		public HashGeneratorResult LastResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool IsBusy => false;

		public static bool IsSupported => false;

		public bool IsGenuineValueSetInInspector => false;

		public void Init()
		{
		}

		public void StartGeneration()
		{
		}

		public bool SummaryHashMatches()
		{
			return false;
		}

		private void OnHashGenerated(HashGeneratorResult result)
		{
		}

		public void DrawUI()
		{
		}
	}
}
