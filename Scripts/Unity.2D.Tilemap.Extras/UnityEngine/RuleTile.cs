using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	public class RuleTile<T> : RuleTile
	{
		public sealed override Type m_NeighborType => null;
	}
	[Serializable]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleTile.html")]
	public class RuleTile : TileBase
	{
		[Serializable]
		public class TilingRuleOutput
		{
			public class Neighbor
			{
				public const int This = 1;

				public const int NotThis = 2;
			}

			public enum Transform
			{
				Fixed = 0,
				Rotated = 1,
				MirrorX = 2,
				MirrorY = 3,
				MirrorXY = 4
			}

			public enum OutputSprite
			{
				Single = 0,
				Random = 1,
				Animation = 2
			}

			public int m_Id;

			public Sprite[] m_Sprites;

			public GameObject m_GameObject;

			[FormerlySerializedAs("m_AnimationSpeed")]
			public float m_MinAnimationSpeed;

			[FormerlySerializedAs("m_AnimationSpeed")]
			public float m_MaxAnimationSpeed;

			public float m_PerlinScale;

			public OutputSprite m_Output;

			public Tile.ColliderType m_ColliderType;

			public Transform m_RandomTransform;
		}

		[Serializable]
		public class TilingRule : TilingRuleOutput
		{
			public List<int> m_Neighbors;

			public List<Vector3Int> m_NeighborPositions;

			public Transform m_RuleTransform;

			public TilingRule Clone()
			{
				return null;
			}

			public Dictionary<Vector3Int, int> GetNeighbors()
			{
				return null;
			}

			public void ApplyNeighbors(Dictionary<Vector3Int, int> dict)
			{
			}

			public BoundsInt GetBounds()
			{
				return default(BoundsInt);
			}
		}

		public class DontOverride : Attribute
		{
		}

		public Sprite m_DefaultSprite;

		public GameObject m_DefaultGameObject;

		public Tile.ColliderType m_DefaultColliderType;

		[HideInInspector]
		public List<TilingRule> m_TilingRules;

		private HashSet<Vector3Int> m_NeighborPositions;

		private static Dictionary<Tilemap, KeyValuePair<HashSet<TileBase>, HashSet<Vector3Int>>> m_CacheTilemapsNeighborPositions;

		private static TileBase[] m_AllocatedUsedTileArr;

		public virtual Type m_NeighborType => null;

		public virtual int m_RotationAngle => 0;

		public int m_RotationCount => 0;

		public HashSet<Vector3Int> neighborPositions => null;

		public void UpdateNeighborPositions()
		{
		}

		public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject instantiatedGameObject)
		{
			return false;
		}

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		public static float GetPerlinValue(Vector3Int position, float scale, float offset)
		{
			return 0f;
		}

		private static bool IsTilemapUsedTilesChange(Tilemap tilemap, out KeyValuePair<HashSet<TileBase>, HashSet<Vector3Int>> hashSet)
		{
			hashSet = default(KeyValuePair<HashSet<TileBase>, HashSet<Vector3Int>>);
			return false;
		}

		private static KeyValuePair<HashSet<TileBase>, HashSet<Vector3Int>> CachingTilemapNeighborPositions(Tilemap tilemap)
		{
			return default(KeyValuePair<HashSet<TileBase>, HashSet<Vector3Int>>);
		}

		private static bool NeedRelease()
		{
			return false;
		}

		private static void ReleaseDestroyedTilemapCacheData()
		{
		}

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public override void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
		}

		public virtual bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, ref Matrix4x4 transform)
		{
			return false;
		}

		public virtual Matrix4x4 ApplyRandomTransform(TilingRuleOutput.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
		{
			return default(Matrix4x4);
		}

		public FieldInfo[] GetCustomFields(bool isOverrideInstance)
		{
			return null;
		}

		public virtual bool RuleMatch(int neighbor, TileBase other)
		{
			return false;
		}

		public bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, int angle)
		{
			return false;
		}

		public bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, bool mirrorX, bool mirrorY)
		{
			return false;
		}

		public virtual Vector3Int GetRotatedPosition(Vector3Int position, int rotation)
		{
			return default(Vector3Int);
		}

		public virtual Vector3Int GetMirroredPosition(Vector3Int position, bool mirrorX, bool mirrorY)
		{
			return default(Vector3Int);
		}

		public virtual Vector3Int GetOffsetPosition(Vector3Int position, Vector3Int offset)
		{
			return default(Vector3Int);
		}

		public virtual Vector3Int GetOffsetPositionReverse(Vector3Int position, Vector3Int offset)
		{
			return default(Vector3Int);
		}
	}
}
