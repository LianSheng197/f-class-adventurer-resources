using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	public class RandomTile : Tile
	{
		[SerializeField]
		public Sprite[] m_Sprites;

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}
	}
}
