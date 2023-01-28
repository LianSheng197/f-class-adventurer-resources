using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class MultilineReactivePropertyAttribute : PropertyAttribute
	{
		public int Lines
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MultilineReactivePropertyAttribute()
		{
		}

		public MultilineReactivePropertyAttribute(int lines)
		{
		}
	}
}
