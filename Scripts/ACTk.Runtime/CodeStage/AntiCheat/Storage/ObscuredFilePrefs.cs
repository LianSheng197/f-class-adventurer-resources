using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace CodeStage.AntiCheat.Storage
{
	public static class ObscuredFilePrefs
	{
		public const string DefaultFileName = "actkfileprefs";

		private const string LogPrefix = "[ACTk] ObscuredFilePrefs: ";

		private static bool isSaved;

		private static ObscuredFile prefsFile;

		private static Dictionary<string, ObscuredPrefsData> prefsCache;

		public static ObscuredFileSettings CurrentSettings => null;

		public static bool IsInited
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool IsLoaded => false;

		public static bool IsExists => false;

		public static string FilePath => null;

		public static ObscuredFileReadResult LastFileReadResult
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredFileReadResult);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ObscuredFileWriteResult LastFileWriteResult
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredFileWriteResult);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static SerializationSettings SerializationSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private static ObscuredFile PrefsFile => null;

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

		public static void Init(bool loadPrefs = false)
		{
		}

		public static void Init(string fileName, bool loadPrefs)
		{
		}

		public static void Init(ObscuredFileSettings settings, bool loadPrefs)
		{
		}

		public static void Init(string fileNameOrPath, ObscuredFileSettings settings, bool loadPrefs)
		{
		}

		public static void UnInit()
		{
		}

		public static void LoadPrefs()
		{
		}

		public static void UnloadPrefs(bool saveBeforeUnloading = true)
		{
		}

		public static bool HasKey(string key)
		{
			return false;
		}

		public static ICollection<string> GetKeys()
		{
			return null;
		}

		public static void DeleteKey(string key)
		{
		}

		public static void DeleteAll()
		{
		}

		public static bool Save()
		{
			return false;
		}

		public static void Set<T>(string key, T value)
		{
		}

		public static T Get<T>(string key, T defaultValue = default(T))
		{
			return default(T);
		}

		[RuntimeInitializeOnLoadMethod]
		private static void RegisterQuitDetection()
		{
		}

		private static bool OnApplicationWantsToQuit()
		{
			return false;
		}

		private static ObscuredFile InitPrefsFile(string fileNameOrPath, ObscuredFileSettings settings)
		{
			return null;
		}

		private static void OnNotGenuineDataDetected()
		{
		}

		private static void OnDataFromAnotherDeviceDetected()
		{
		}

		private static Dictionary<string, ObscuredPrefsData> LoadAndDeserializePrefs()
		{
			return null;
		}

		private static ObscuredFileWriteResult SerializeAndSavePrefs()
		{
			return default(ObscuredFileWriteResult);
		}

		private static T ReadPref<T>(string key, T defaultValue)
		{
			return default(T);
		}

		private static void WritePref<T>(string key, T value)
		{
		}

		private static ObscuredFileReadResult ReadAllBytesInternal()
		{
			return default(ObscuredFileReadResult);
		}

		private static ObscuredFileWriteResult WriteAllBytesInternal(byte[] data)
		{
			return default(ObscuredFileWriteResult);
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
	}
}
