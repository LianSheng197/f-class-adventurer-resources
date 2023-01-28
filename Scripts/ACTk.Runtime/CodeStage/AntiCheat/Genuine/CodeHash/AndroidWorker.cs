using System.Reflection;
using UnityEngine;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class AndroidWorker : BaseWorker
	{
		[Obfuscation(Exclude = true, ApplyToMembers = false)]
		private class CodeHashGeneratorCallback : AndroidJavaProxy
		{
			private readonly AndroidWorker parent;

			public CodeHashGeneratorCallback(AndroidWorker parent)
				: base((string)null)
			{
			}

			[Obfuscation(Exclude = true)]
			public void OnSuccess(string buildPath, string[] paths, string[] hashes, string summaryHash)
			{
			}

			[Obfuscation(Exclude = true)]
			public void OnError(string errorMessage)
			{
			}
		}

		public override void Execute()
		{
		}

		private string[] GenerateStringArrayFromFilters(FileFilter[] filters)
		{
			return null;
		}
	}
}
