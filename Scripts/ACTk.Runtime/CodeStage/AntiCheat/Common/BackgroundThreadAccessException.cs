using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Common
{
	internal class BackgroundThreadAccessException : Exception
	{
		public string AccessedApi
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public BackgroundThreadAccessException(string apiName)
		{
		}
	}
}
