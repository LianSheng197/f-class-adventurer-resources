using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/AnimatedTile.html")]
	public class AnimatedTile : TileBase
	{
		public Sprite[] m_AnimatedSprites;

		public float m_MinSpeed;

		public float m_MaxSpeed;

		public float m_AnimationStartTime;

		public int m_AnimationStartFrame;

		public Tile.ColliderType m_TileColliderType;

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}
	}
}
