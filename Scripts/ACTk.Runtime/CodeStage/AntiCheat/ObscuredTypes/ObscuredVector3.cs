using System;
using System.Reflection;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	[DefaultMember("Item")]
	public struct ObscuredVector3 : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector3
		{
			public int x;

			public int y;

			public int z;
		}

		private static readonly Vector3 Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector3 fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public float x
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float z
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Item
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private ObscuredVector3(Vector3 value)
		{
		}

		public ObscuredVector3(float x, float y, float z)
		{
		}

		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			return default(RawEncryptedVector3);
		}

		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		public static ObscuredVector3 FromEncrypted(RawEncryptedVector3 encrypted, int key)
		{
			return default(ObscuredVector3);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		private static bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return false;
		}

		public RawEncryptedVector3 GetEncrypted(out int key)
		{
			key = default(int);
			return default(RawEncryptedVector3);
		}

		public void SetEncrypted(RawEncryptedVector3 encrypted, int key)
		{
		}

		public Vector3 GetDecrypted()
		{
			return default(Vector3);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		private void Init()
		{
		}

		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
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

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}
	}
}
