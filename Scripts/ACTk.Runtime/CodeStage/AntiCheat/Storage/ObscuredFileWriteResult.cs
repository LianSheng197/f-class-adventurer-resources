using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public readonly struct ObscuredFileWriteResult
	{
		public bool Success => false;

		public ObscuredFileError Error
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredFileError);
			}
		}

		public bool IsValid
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal ObscuredFileWriteResult(ObscuredFileErrorCode result)
		{
		}

		private ObscuredFileWriteResult(ObscuredFileError error)
		{
		}

		internal static ObscuredFileWriteResult FromError(Exception exception)
		{
			return default(ObscuredFileWriteResult);
		}

		internal static ObscuredFileWriteResult FromError(ObscuredFileErrorCode errorCode)
		{
			return default(ObscuredFileWriteResult);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
