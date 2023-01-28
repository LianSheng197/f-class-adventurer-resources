using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace CodeStage.AntiCheat.Storage
{
	public static class ObscuredPrefs
	{
		internal const string PrefsKey = "9978e9f39c218d674463dab9dc728bd6";

		private const string RawNotFound = "{not_found}";

		private const string LogPrefix = "[ACTk] ObscuredPrefs: ";

		private const byte Version = 4;

		private static bool alterationReported;

		private static bool foreignSavesReported;

		private static string cryptoKeyObsolete;

		private static string cryptoKeyObsoleteForMigration;

		private static DeviceIdHolder deviceIdHolder;

		public static bool preservePlayerPrefs;

		private static char[] generatedCryptoKey;

		[Obsolete("Custom crypto key is now obsolete, use only for data recovery from prefs saved with previous version. This property will be removed in future versions.")]
		public static string CryptoKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Please use DeviceIdHolder.DeviceId instead.", false)]
		public static string DeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static DeviceIdHolder DeviceIdHolder => null;

		public static DeviceLockSettings DeviceLockSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Obsolete("Please use DeviceLockSettings.DeviceLockLevel property instead.", false)]
		public static DeviceLockLevel lockToDevice
		{
			get
			{
				return default(DeviceLockLevel);
			}
			set
			{
			}
		}

		[Obsolete("Please use DeviceLockSettings.DeviceLockTamperingSensitivity property instead.", false)]
		public static bool readForeignSaves
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use DeviceLockSettings.DeviceLockTamperingSensitivity property instead.", false)]
		public static bool emergencyMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use NotGenuineDataDetected event instead.", false)]
		public static event Action OnAlterationDetected
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

		[Obsolete("Please use DataFromAnotherDeviceDetected event instead.", false)]
		public static event Action OnPossibleForeignSavesDetected
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

		public static event Action NotGenuineDataDetected
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

		public static event Action DataFromAnotherDeviceDetected
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

		[Obsolete("Please use DeviceIdHolder.ForceLockToDeviceInit() instead.", false)]
		public static void ForceLockToDeviceInit()
		{
		}

		public static void SetRawValue(string encryptedKey, string encryptedValue)
		{
		}

		public static bool GetRawValue(string key, out string encryptedKey, out string encryptedValue)
		{
			encryptedKey = null;
			encryptedValue = null;
			return false;
		}

		public static bool HasKey(string key)
		{
			return false;
		}

		public static void DeleteKey(string key)
		{
		}

		public static void DeleteCryptoKey()
		{
		}

		public static void DeleteAll()
		{
		}

		public static void Save()
		{
		}

		public static void Set<T>(string key, T value)
		{
		}

		public static T Get<T>(string key, T defaultValue = default(T))
		{
			return default(T);
		}

		private static T ReadFromRegularPrefs<T>(string key, T defaultValue)
		{
			return default(T);
		}

		private static void SetStringPref(string encryptedKey, string encryptedValue)
		{
		}

		public static bool MigrateFromACTkV1(string key, string cryptoKey = "e806f6")
		{
			return false;
		}

		public static string EncryptKeyWithACTkV1Algorithm(string key, string cryptoKey = "e806f6")
		{
			return null;
		}

		private static void SavesTampered()
		{
		}

		private static void PossibleForeignSavesDetected()
		{
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetInt(string key, int value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static int GetInt(string key, int defaultValue = 0)
		{
			return 0;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetUInt(string key, uint value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static uint GetUInt(string key, uint defaultValue = 0u)
		{
			return 0u;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetString(string key, string value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetFloat(string key, float value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static float GetFloat(string key, float defaultValue = 0f)
		{
			return 0f;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetDouble(string key, double value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static double GetDouble(string key, double defaultValue = 0.0)
		{
			return 0.0;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetDecimal(string key, decimal value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static decimal GetDecimal(string key, decimal defaultValue = 0m)
		{
			return default(decimal);
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetLong(string key, long value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static long GetLong(string key, long defaultValue = 0L)
		{
			return 0L;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetULong(string key, ulong value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static ulong GetULong(string key, ulong defaultValue = 0uL)
		{
			return 0uL;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetBool(string key, bool value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static bool GetBool(string key, bool defaultValue = false)
		{
			return false;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static byte[] GetByteArray(string key, byte defaultValue = 0, int defaultLength = 0)
		{
			return null;
		}

		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates. Be careful with Color and Color32 difference!", false)]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates. Be careful with Color and Color32 difference!", false)]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates. Be careful with Color and Color32 difference!", false)]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Obsolete("Please use generic Set instead. This API will be removed in next updates.", false)]
		public static void SetRect(string key, Rect value)
		{
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Obsolete("Please use generic Get instead. This API will be removed in next updates.", false)]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		public static void Set(string key, ObscuredBool value)
		{
		}

		public static void Set(string key, ObscuredByte value)
		{
		}

		public static void Set(string key, ObscuredChar value)
		{
		}

		public static void Set(string key, ObscuredDecimal value)
		{
		}

		public static void Set(string key, ObscuredDouble value)
		{
		}

		public static void Set(string key, ObscuredFloat value)
		{
		}

		public static void Set(string key, ObscuredInt value)
		{
		}

		public static void Set(string key, ObscuredLong value)
		{
		}

		public static void Set(string key, ObscuredQuaternion value)
		{
		}

		public static void Set(string key, ObscuredSByte value)
		{
		}

		public static void Set(string key, ObscuredShort value)
		{
		}

		public static void Set(string key, ObscuredString value)
		{
		}

		public static void Set(string key, ObscuredUInt value)
		{
		}

		public static void Set(string key, ObscuredULong value)
		{
		}

		public static void Set(string key, ObscuredUShort value)
		{
		}

		public static void Set(string key, ObscuredVector2 value)
		{
		}

		public static void Set(string key, ObscuredVector2Int value)
		{
		}

		public static void Set(string key, ObscuredVector3 value)
		{
		}

		public static void Set(string key, ObscuredVector3Int value)
		{
		}

		public static ObscuredBool Get(string key, ObscuredBool defaultValue = default(ObscuredBool))
		{
			return default(ObscuredBool);
		}

		public static ObscuredByte Get(string key, ObscuredByte defaultValue = default(ObscuredByte))
		{
			return default(ObscuredByte);
		}

		public static ObscuredChar Get(string key, ObscuredChar defaultValue = default(ObscuredChar))
		{
			return default(ObscuredChar);
		}

		public static ObscuredDecimal Get(string key, ObscuredDecimal defaultValue = default(ObscuredDecimal))
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDouble Get(string key, ObscuredDouble defaultValue = default(ObscuredDouble))
		{
			return default(ObscuredDouble);
		}

		public static ObscuredFloat Get(string key, ObscuredFloat defaultValue = default(ObscuredFloat))
		{
			return default(ObscuredFloat);
		}

		public static ObscuredInt Get(string key, ObscuredInt defaultValue = default(ObscuredInt))
		{
			return default(ObscuredInt);
		}

		public static ObscuredLong Get(string key, ObscuredLong defaultValue = default(ObscuredLong))
		{
			return default(ObscuredLong);
		}

		public static ObscuredQuaternion Get(string key, ObscuredQuaternion defaultValue = default(ObscuredQuaternion))
		{
			return default(ObscuredQuaternion);
		}

		public static ObscuredSByte Get(string key, ObscuredSByte defaultValue = default(ObscuredSByte))
		{
			return default(ObscuredSByte);
		}

		public static ObscuredShort Get(string key, ObscuredShort defaultValue = default(ObscuredShort))
		{
			return default(ObscuredShort);
		}

		public static ObscuredString Get(string key, ObscuredString defaultValue = null)
		{
			return null;
		}

		public static ObscuredUInt Get(string key, ObscuredUInt defaultValue = default(ObscuredUInt))
		{
			return default(ObscuredUInt);
		}

		public static ObscuredULong Get(string key, ObscuredULong defaultValue = default(ObscuredULong))
		{
			return default(ObscuredULong);
		}

		public static ObscuredUShort Get(string key, ObscuredUShort defaultValue = default(ObscuredUShort))
		{
			return default(ObscuredUShort);
		}

		public static ObscuredVector2 Get(string key, ObscuredVector2 defaultValue = default(ObscuredVector2))
		{
			return default(ObscuredVector2);
		}

		public static ObscuredVector2Int Get(string key, ObscuredVector2Int defaultValue = default(ObscuredVector2Int))
		{
			return default(ObscuredVector2Int);
		}

		public static ObscuredVector3 Get(string key, ObscuredVector3 defaultValue = default(ObscuredVector3))
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3Int Get(string key, ObscuredVector3Int defaultValue = default(ObscuredVector3Int))
		{
			return default(ObscuredVector3Int);
		}

		internal static char[] GetCryptoKey(string dynamicSuffix = null, string prefsKey = "9978e9f39c218d674463dab9dc728bd6")
		{
			return null;
		}

		internal static string EncryptKey(string key)
		{
			return null;
		}

		internal static StorageDataType GetRawValueType(string value)
		{
			return default(StorageDataType);
		}

		internal static string EncryptValue<T>(string key, T value)
		{
			return null;
		}

		internal static T DecryptValue<T>(string key, string encryptedKey, T defaultValue, string encryptedInput = null)
		{
			return default(T);
		}

		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		private static string EncryptData(string key, byte[] cleanBytes, StorageDataType type)
		{
			return null;
		}

		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, char[] key)
		{
			return null;
		}

		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		private static bool MigrateFromACTkV1Internal(string key, string cryptoKey)
		{
			return false;
		}

		private static byte[] EncryptDecryptBytesObsolete(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		private static byte[] DeviceIdHashModifier(string input)
		{
			return null;
		}
	}
}
