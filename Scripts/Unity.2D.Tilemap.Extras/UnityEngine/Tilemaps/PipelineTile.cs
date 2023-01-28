using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	public class PipelineTile : TileBase
	{
		[SerializeField]
		public Sprite[] m_Sprites;

		public override void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
		}

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		private void UpdateTile(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		private bool TileValue(ITilemap tileMap, Vector3Int position)
		{
			return false;
		}

		private int GetIndex(byte mask)
		{
			return 0;
		}

		private Matrix4x4 GetTransform(byte mask)
		{
			return default(Matrix4x4);
		}
	}
}
