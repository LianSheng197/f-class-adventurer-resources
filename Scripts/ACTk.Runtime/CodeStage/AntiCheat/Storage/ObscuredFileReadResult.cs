using System;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public readonly struct ObscuredFileReadResult
	{
		public bool Success => false;

		public byte[] Data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool CheatingDetected => false;

		public bool DataIsNotGenuine
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool DataFromAnotherDevice
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

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

		internal ObscuredFileReadResult(byte[] data, bool dataIsNotGenuine, bool dataFromAnotherDevice)
		{
		}

		private ObscuredFileReadResult(ObscuredFileError error)
		{
		}

		internal static ObscuredFileReadResult FromError(Exception exception)
		{
			return default(ObscuredFileReadResult);
		}

		internal static ObscuredFileReadResult FromError(ObscuredFileErrorCode errorCode)
		{
			return default(ObscuredFileReadResult);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
