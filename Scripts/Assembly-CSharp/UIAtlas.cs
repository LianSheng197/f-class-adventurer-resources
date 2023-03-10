using System;
using System.Collections.Generic;
using UnityEngine;

public class UIAtlas : MonoBehaviour, INGUIAtlas
{
	[Serializable]
	private class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding => false;
	}

	private enum Coordinates
	{
		Pixels = 0,
		TexCoords = 1
	}

	[SerializeField]
	[HideInInspector]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites;

	[SerializeField]
	[HideInInspector]
	private float mPixelSize;

	[SerializeField]
	[HideInInspector]
	private UnityEngine.Object mReplacement;

	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[SerializeField]
	[HideInInspector]
	private List<Sprite> sprites;

	[NonSerialized]
	private int mPMA;

	[NonSerialized]
	private Dictionary<string, int> mSpriteIndices;

	public Material spriteMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool premultipliedAlpha => false;

	public List<UISpriteData> spriteList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Texture texture => null;

	public float pixelSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public INGUIAtlas replacement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	public void MarkSpriteListAsChanged()
	{
	}

	public void SortAlphabetically()
	{
	}

	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	public bool References(INGUIAtlas atlas)
	{
		return false;
	}

	public void MarkAsChanged()
	{
	}

	private bool Upgrade()
	{
		return false;
	}
}
