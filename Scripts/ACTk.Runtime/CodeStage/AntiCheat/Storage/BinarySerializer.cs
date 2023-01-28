using System.Collections.Generic;
using System.IO;

namespace CodeStage.AntiCheat.Storage
{
	internal class BinarySerializer : IObscuredFilePrefsSerializer
	{
		private const byte Version = 0;

		private static BinarySerializer cachedInstance;

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

		private void WritePref(BinaryWriter writer, string key, ObscuredPrefsData value)
		{
		}

		private (string, ObscuredPrefsData) ReadPref(BinaryReader reader)
		{
			return default((string, ObscuredPrefsData));
		}
	}
}
