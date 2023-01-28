using UnityEngine;

namespace CodeStage.AntiCheat.Storage
{
	internal static class StorageDataConverter
	{
		public static Color32 BytesToColor32Legacy(byte[] data)
		{
			return default(Color32);
		}

		public static ObscuredPrefsData GetPrefsDataFromValue<T>(T value)
		{
			return default(ObscuredPrefsData);
		}

		public static T GetValueFromPrefsData<T>(ObscuredPrefsData prefsData)
		{
			return default(T);
		}

		public static T GetValueFromData<T>(byte[] data)
		{
			return default(T);
		}

		public static T GetValueFromData<T>(StorageDataType type, byte[] data)
		{
			return default(T);
		}

		private static byte[] GetBytesFromValue<T>(StorageDataType type, T value)
		{
			return null;
		}

		private static T GetValueFromBytes<T>(StorageDataType type, byte[] data)
		{
			return default(T);
		}

		private static byte[] ConvertToBytes<T>(T value) where T : struct
		{
			return null;
		}

		private static T ConvertToValue<T>(byte[] data) where T : struct
		{
			return default(T);
		}
	}
}
