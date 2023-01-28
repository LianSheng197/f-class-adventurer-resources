using System;

namespace CodeStage.AntiCheat.Storage
{
	internal static class StorageDataTypeClassifier
	{
		private static readonly Type SByteType;

		private static readonly Type ByteType;

		private static readonly Type ShortType;

		private static readonly Type UShortType;

		private static readonly Type IntType;

		private static readonly Type UIntType;

		private static readonly Type LongType;

		private static readonly Type ULongType;

		private static readonly Type CharType;

		private static readonly Type StringType;

		private static readonly Type FloatType;

		private static readonly Type DoubleType;

		private static readonly Type DecimalType;

		private static readonly Type BoolType;

		private static readonly Type DateTimeType;

		private static readonly Type ByteArray;

		private static readonly Type Vector2Type;

		private static readonly Type Vector2IntType;

		private static readonly Type Vector3Type;

		private static readonly Type Vector3IntType;

		private static readonly Type Vector4Type;

		private static readonly Type QuaternionType;

		private static readonly Type ColorType;

		private static readonly Type Color32Type;

		private static readonly Type RectType;

		private static readonly Type RectIntType;

		private static readonly Type RangeIntType;

		private static readonly Type Matrix4x4Type;

		private static readonly Type RayType;

		private static readonly Type Ray2DType;

		public static StorageDataType GetStorageDataType<T>()
		{
			return default(StorageDataType);
		}
	}
}
