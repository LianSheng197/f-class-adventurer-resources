using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IObscuredType, IFormattable, IEquatable<ObscuredFloat>, IComparable<ObscuredFloat>, IComparable<float>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		internal struct FloatIntBytesUnion
		{
			internal float f;

			internal int i;

			internal ACTkByte4 b4;

			public static int Migrate(int value, byte fromVersion, byte toVersion)
			{
				return 0;
			}

			internal static int XorFloatToInt(float value, int key)
			{
				return 0;
			}

			internal static float XorIntToFloat(int value, int key)
			{
				return 0f;
			}

			private static FloatIntBytesUnion FromFloat(float value)
			{
				return default(FloatIntBytesUnion);
			}

			private static FloatIntBytesUnion FromInt(int value)
			{
				return default(FloatIntBytesUnion);
			}

			private FloatIntBytesUnion Shuffle(int key)
			{
				return default(FloatIntBytesUnion);
			}

			private FloatIntBytesUnion UnShuffle(int key)
			{
				return default(FloatIntBytesUnion);
			}
		}

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte4 hiddenValueOldByte4;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private float fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredFloat(float value)
		{
		}

		public static int Encrypt(float value, int key)
		{
			return 0;
		}

		public static float Decrypt(int value, int key)
		{
			return 0f;
		}

		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return 0;
		}

		public static ObscuredFloat FromEncrypted(int encrypted, int key)
		{
			return default(ObscuredFloat);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		public int GetEncrypted(out int key)
		{
			key = default(int);
			return 0;
		}

		public void SetEncrypted(int encrypted, int key)
		{
		}

		public float GetDecrypted()
		{
			return 0f;
		}

		public void RandomizeCryptoKey()
		{
		}

		private float InternalDecrypt()
		{
			return 0f;
		}

		private void Init()
		{
		}

		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator float(ObscuredFloat value)
		{
			return 0f;
		}

		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		private static ObscuredFloat Increment(ObscuredFloat input, int increment)
		{
			return default(ObscuredFloat);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredFloat obj)
		{
			return false;
		}

		public int CompareTo(ObscuredFloat other)
		{
			return 0;
		}

		public int CompareTo(float other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static int Encrypt(float value)
		{
			return 0;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static float Decrypt(int value)
		{
			return 0f;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredFloat FromEncrypted(int encrypted)
		{
			return default(ObscuredFloat);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public int GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(int encrypted)
		{
		}
	}
}
