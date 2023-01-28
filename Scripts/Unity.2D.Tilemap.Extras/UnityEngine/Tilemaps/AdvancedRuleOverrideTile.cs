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
	public class AdvancedRuleOverrideTile : RuleOverrideTile
	{
		public Sprite m_DefaultSprite;

		public GameObject m_DefaultGameObject;

		public Tile.ColliderType m_DefaultColliderType;

		public List<RuleTile.TilingRuleOutput> m_OverrideTilingRules;

		public new RuleTile.TilingRuleOutput Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void ApplyOverrides(IList<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRuleOutput>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRuleOutput>> overrides, ref int validCount)
		{
		}

		public override void Override()
		{
		}
	}
}
