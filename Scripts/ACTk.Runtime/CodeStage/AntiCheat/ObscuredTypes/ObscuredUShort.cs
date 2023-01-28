using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IObscuredType, IFormattable, IEquatable<ObscuredUShort>, IComparable<ObscuredUShort>, IComparable<ushort>, IComparable
	{
		private ushort currentCryptoKey;

		private ushort hiddenValue;

		private bool inited;

		private ushort fakeValue;

		private bool fakeValueActive;

		private ObscuredUShort(ushort value)
		{
		}

		public static ushort Encrypt(ushort value, ushort key)
		{
			return 0;
		}

		public static ushort Decrypt(ushort value, ushort key)
		{
			return 0;
		}

		public static ObscuredUShort FromEncrypted(ushort encrypted, ushort key)
		{
			return default(ObscuredUShort);
		}

		public static ushort GenerateKey()
		{
			return 0;
		}

		public ushort GetEncrypted(out ushort key)
		{
			key = default(ushort);
			return 0;
		}

		public void SetEncrypted(ushort encrypted, ushort key)
		{
		}

		public ushort GetDecrypted()
		{
			return 0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private ushort InternalDecrypt()
		{
			return 0;
		}

		private void Init()
		{
		}

		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		public static implicit operator ushort(ObscuredUShort value)
		{
			return 0;
		}

		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		private static ObscuredUShort Increment(ObscuredUShort input, int increment)
		{
			return default(ObscuredUShort);
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

		public bool Equals(ObscuredUShort obj)
		{
			return false;
		}

		public int CompareTo(ObscuredUShort other)
		{
			return 0;
		}

		public int CompareTo(ushort other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static ushort EncryptDecrypt(ushort value)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return 0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredUShort FromEncrypted(ushort encrypted)
		{
			return default(ObscuredUShort);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public ushort GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(ushort encrypted)
		{
		}
	}
}
