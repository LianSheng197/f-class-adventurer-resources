using CodeStage.AntiCheat.Storage;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	internal class ObscuredPrefsExamples : MonoBehaviour
	{
		private const string PrefsString = "name";

		private const string PrefsInt = "money";

		private const string PrefsFloat = "lifeBar";

		private const string PrefsBool = "gameComplete";

		private const string PrefsUint = "demoUint";

		private const string PrefsLong = "demoLong";

		private const string PrefsDouble = "demoDouble";

		private const string PrefsVector2 = "demoVector2";

		private const string PrefsVector3 = "demoVector3";

		private const string PrefsQuaternion = "demoQuaternion";

		private const string PrefsRect = "demoRect";

		private const string PrefsColor = "demoColor";

		private const string PrefsColor32 = "demoColor32";

		private const string PrefsByteArray = "demoByteArray";

		[ColorUsage(true, true)]
		[SerializeField]
		private Color hdrColor;

		private string regularPrefs;

		private string obscuredPrefs;

		private bool savesAlterationDetected;

		private bool foreignSavesDetected;

		private DeviceLockLevel savesLock;

		private DeviceLockTamperingSensitivity tamperingSensitivity;

		private bool PreservePlayerPrefs
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSavesNotGenuineDataDetected()
		{
		}

		private void OnDataFromAnotherDeviceDetected()
		{
		}

		private void LoadRegularPrefs()
		{
		}

		private void SaveRegularPrefs()
		{
		}

		private void DeleteRegularPrefs()
		{
		}

		private void ApplyDeviceLockLevel(DeviceLockLevel level)
		{
		}

		private void ApplyTamperingSensitivity(DeviceLockTamperingSensitivity value)
		{
		}

		private void LoadObscuredPrefs()
		{
		}

		private void SaveObscuredPrefs()
		{
		}

		private void DeleteObscuredPrefs()
		{
		}

		private void MigrateFromV1()
		{
		}

		public void DrawUI()
		{
		}
	}
}
