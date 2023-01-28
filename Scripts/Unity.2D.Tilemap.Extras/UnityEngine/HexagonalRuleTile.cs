using System;

namespace UnityEngine
{
	public class HexagonalRuleTile<T> : HexagonalRuleTile
	{
		public sealed override Type m_NeighborType => null;
	}
	[Serializable]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleTile.html")]
	public class HexagonalRuleTile : RuleTile
	{
		private static float[] m_CosAngleArr1;

		private static float[] m_SinAngleArr1;

		private static float[] m_CosAngleArr2;

		private static float[] m_SinAngleArr2;

		[DontOverride]
		public bool m_FlatTop;

		private static float m_TilemapToWorldYScale;

		public override int m_RotationAngle => 0;

		public static Vector3 TilemapPositionToWorldPosition(Vector3Int tilemapPosition)
		{
			return default(Vector3);
		}

		public static Vector3Int WorldPositionToTilemapPosition(Vector3 worldPosition)
		{
			return default(Vector3Int);
		}

		public override Vector3Int GetOffsetPosition(Vector3Int position, Vector3Int offset)
		{
			return default(Vector3Int);
		}

		public override Vector3Int GetOffsetPositionReverse(Vector3Int position, Vector3Int offset)
		{
			return default(Vector3Int);
		}

		public override Vector3Int GetRotatedPosition(Vector3Int position, int rotation)
		{
			return default(Vector3Int);
		}

		public override Vector3Int GetMirroredPosition(Vector3Int position, bool mirrorX, bool mirrorY)
		{
			return default(Vector3Int);
		}
	}
}
