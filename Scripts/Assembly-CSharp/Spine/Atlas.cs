using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Spine
{
	public class Atlas : IEnumerable<AtlasRegion>, IEnumerable
	{
		private readonly List<AtlasPage> pages;

		private List<AtlasRegion> regions;

		private TextureLoader textureLoader;

		public IEnumerator<AtlasRegion> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public Atlas(TextReader reader, string dir, TextureLoader textureLoader)
		{
		}

		public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions)
		{
		}

		private void Load(TextReader reader, string imagesDir, TextureLoader textureLoader)
		{
		}

		private static string ReadValue(TextReader reader)
		{
			return null;
		}

		private static int ReadTuple(TextReader reader, string[] tuple)
		{
			return 0;
		}

		public void FlipV()
		{
		}

		public AtlasRegion FindRegion(string name)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
