using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity
{
	internal class GraphResult : ResultBase, IGraphResult, IResult
	{
		public IList<object> ResultList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Texture2D Texture
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal GraphResult(WWW result)
			: base(null)
		{
		}

		private void Init(string rawResult)
		{
		}
	}
}
