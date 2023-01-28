using System.Runtime.CompilerServices;

namespace Spine
{
	public class MeshAttachment : VertexAttachment, IHasRendererObject
	{
		internal float regionOffsetX;

		internal float regionOffsetY;

		internal float regionWidth;

		internal float regionHeight;

		internal float regionOriginalWidth;

		internal float regionOriginalHeight;

		private MeshAttachment parentMesh;

		internal float[] uvs;

		internal float[] regionUVs;

		internal int[] triangles;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal int hulllength;

		internal bool inheritDeform;

		public int HullLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float[] RegionUVs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float[] UVs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int[] Triangles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float R
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float G
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float B
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float A
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object RendererObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RegionU
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RegionV
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RegionU2
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RegionV2
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool RegionRotate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float RegionOffsetX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOffsetY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOriginalWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOriginalHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InheritDeform
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MeshAttachment ParentMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int[] Edges
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Width
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Height
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MeshAttachment(string name)
			: base(null)
		{
		}

		public void UpdateUVs()
		{
		}

		public override bool ApplyDeform(VertexAttachment sourceAttachment)
		{
			return false;
		}
	}
}
