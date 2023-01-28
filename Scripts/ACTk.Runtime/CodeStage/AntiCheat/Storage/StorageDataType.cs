namespace CodeStage.AntiCheat.Storage
{
	public enum StorageDataType : byte
	{
		Unknown = 0,
		SByte = 1,
		Byte = 2,
		Int16 = 3,
		UInt16 = 4,
		Int32 = 5,
		UInt32 = 10,
		Int64 = 30,
		UInt64 = 32,
		Char = 33,
		Single = 20,
		Double = 25,
		Decimal = 27,
		Boolean = 35,
		String = 15,
		DateTime = 37,
		ByteArray = 40,
		Vector2 = 45,
		Vector2Int = 47,
		Vector3 = 50,
		Vector3Int = 51,
		Vector4 = 53,
		Quaternion = 55,
		Color = 60,
		Color32 = 62,
		Rect = 65,
		RectInt = 67,
		RangeInt = 70,
		Matrix4x4 = 78,
		Ray = 80,
		Ray2D = 83
	}
}
