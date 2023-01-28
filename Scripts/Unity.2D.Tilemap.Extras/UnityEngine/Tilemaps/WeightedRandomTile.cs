using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	public class WeightedRandomTile : Tile
	{
		[SerializeField]
		public WeightedSprite[] Sprites;

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}
	}
}
