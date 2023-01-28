using System.Collections.Generic;

namespace CodeStage.AntiCheat.Storage
{
	internal interface IObscuredFilePrefsSerializer
	{
		ObscuredPrefsData SerializeStorageDataType<T>(T value);

		T DeserializeStorageDataType<T>(ObscuredPrefsData data);

		byte[] SerializePrefsDictionary(Dictionary<string, ObscuredPrefsData> dictionary);

		Dictionary<string, ObscuredPrefsData> DeserializePrefsDictionary(byte[] data);
	}
}
