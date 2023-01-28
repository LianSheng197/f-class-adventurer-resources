using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class BuildHashes
	{
		public string BuildPath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public FileHash[] FileHashes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string SummaryHash
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal BuildHashes(string buildPath, List<FileHash> fileHashes, SHA1Wrapper sha1)
		{
		}

		internal BuildHashes(string buildPath, FileHash[] fileHashes, string summaryHash)
		{
		}

		public bool HasFileHash(string hash)
		{
			return false;
		}

		public void PrintToConsole()
		{
		}

		private string CalculateSummaryCodeHash(List<FileHash> fileHashes, SHA1Wrapper sha1)
		{
			return null;
		}
	}
}
