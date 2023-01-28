using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class RangeReactivePropertyAttribute : PropertyAttribute
	{
		public float Min
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float Max
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RangeReactivePropertyAttribute(float min, float max)
		{
		}
	}
}
