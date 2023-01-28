using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public readonly struct ObscuredFileError
	{
		public ObscuredFileErrorCode ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredFileErrorCode);
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal ObscuredFileError(ObscuredFileErrorCode code)
		{
		}

		internal ObscuredFileError(Exception exception)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
