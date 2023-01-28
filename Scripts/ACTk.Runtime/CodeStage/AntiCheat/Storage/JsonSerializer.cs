using System.Collections.Generic;

namespace CodeStage.AntiCheat.Storage
{
	internal class JsonSerializer : IObscuredFilePrefsSerializer
	{
		private static JsonSerializer cachedInstance;

		public static IObscuredFilePrefsSerializer GetSerializer()
		{
			return null;
		}

		public ObscuredPrefsData SerializeStorageDataType<T>(T value)
		{
			return default(ObscuredPrefsData);
		}

		public T DeserializeStorageDataType<T>(ObscuredPrefsData data)
		{
			return default(T);
		}

		public byte[] SerializePrefsDictionary(Dictionary<string, ObscuredPrefsData> dictionary)
		{
			return null;
		}

		public Dictionary<string, ObscuredPrefsData> DeserializePrefsDictionary(byte[] data)
		{
			return null;
		}
	}
}
