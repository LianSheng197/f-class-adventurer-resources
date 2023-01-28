using System;

namespace CodeStage.AntiCheat.Storage
{
	[Serializable]
	internal struct ObscuredPrefsData
	{
		public StorageDataType type;

		public byte[] data;

		public ObscuredPrefsData(StorageDataType type, byte[] data)
		{
		}
	}
}
