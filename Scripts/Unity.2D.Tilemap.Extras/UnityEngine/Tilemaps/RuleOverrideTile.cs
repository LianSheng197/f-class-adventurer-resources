using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleOverrideTile.html")]
	[MovedFrom(true, "UnityEngine", null, null)]
	[DefaultMember("Item")]
	public class RuleOverrideTile : TileBase
	{
		[Serializable]
		public class TileSpritePair
		{
			public Sprite m_OriginalSprite;

			public Sprite m_OverrideSprite;
		}

		[Serializable]
		public class TileGameObjectPair
		{
			public GameObject m_OriginalGameObject;

			public GameObject m_OverrideGameObject;
		}

		public RuleTile m_Tile;

		public List<TileSpritePair> m_Sprites;

		public List<TileGameObjectPair> m_GameObjects;

		[HideInInspector]
		public RuleTile m_InstanceTile;

		public Sprite Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void ApplyOverrides(IList<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		public void ApplyOverrides(IList<KeyValuePair<GameObject, GameObject>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<Sprite, Sprite>> overrides, ref int validCount)
		{
		}

		public void GetOverrides(List<KeyValuePair<GameObject, GameObject>> overrides, ref int validCount)
		{
		}

		public virtual void Override()
		{
		}

		public void PrepareOverride()
		{
		}

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		public override void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
		}

		public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			return false;
		}

		public void OnEnable()
		{
		}
	}
}
