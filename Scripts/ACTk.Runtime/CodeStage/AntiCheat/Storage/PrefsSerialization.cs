using System.Collections.Generic;

namespace CodeStage.AntiCheat.Storage
{
	internal static class PrefsSerialization
	{
		public static ObscuredPrefsData SerializeStorageDataType<T>(T value, SerializationSettings settings)
		{
			return default(ObscuredPrefsData);
		}

		public static T DeserializeStorageDataType<T>(ObscuredPrefsData data, SerializationSettings settings)
		{
			return default(T);
		}

		public static byte[] SerializePrefsDictionary(Dictionary<string, ObscuredPrefsData> value, SerializationSettings settings)
		{
			return null;
		}

		public static Dictionary<string, ObscuredPrefsData> DeserializePrefsDictionary(byte[] data, SerializationSettings settings)
		{
			return null;
		}

		private static IObscuredFilePrefsSerializer GetSerializer(SerializationSettings settings)
		{
			return null;
		}
	}
}
