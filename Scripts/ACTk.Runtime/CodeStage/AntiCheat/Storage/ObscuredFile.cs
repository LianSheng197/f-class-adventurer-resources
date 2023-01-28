using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public class ObscuredFile
	{
		private const string LogPrefix = "[ACTk] ObscuredFile: ";

		public const string DefaultFileName = "actkfile";

		private static readonly DeviceIdHolder DeviceIdHolder;

		public ObscuredFileSettings CurrentSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool FileExists => false;

		public string FilePath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public event Action NotGenuineDataDetected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action DataFromAnotherDeviceDetected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Conditional("ACTK_DEV_LOGS")]
		private static void DevLog(string log)
		{
		}

		public ObscuredFile()
		{
		}

		public ObscuredFile(string fileName)
		{
		}

		public ObscuredFile(ObscuredFileSettings settings)
		{
		}

		public ObscuredFile(string fileNameOrPath, ObscuredFileSettings settings)
		{
		}

		public void Delete()
		{
		}

		public ObscuredFileWriteResult WriteAllBytes(byte[] data)
		{
			return default(ObscuredFileWriteResult);
		}

		public ObscuredFileReadResult ReadAllBytes()
		{
			return default(ObscuredFileReadResult);
		}

		private ObscuredFileReadResult ReadAllBytesInternal()
		{
			return default(ObscuredFileReadResult);
		}

		private ObscuredFileHeader ReadHeader(Stream output)
		{
			return default(ObscuredFileHeader);
		}

		private ObscuredFileWriteResult WriteAllBytesInternal(byte[] data)
		{
			return default(ObscuredFileWriteResult);
		}

		private void WriteHeader(Stream memory)
		{
		}

		private void ApplyDeviceLockIfNeeded(Stream writer, DeviceLockLevel deviceLockLevel)
		{
		}

		private string ConstructFilePath(string fileName)
		{
			return null;
		}
	}
}
