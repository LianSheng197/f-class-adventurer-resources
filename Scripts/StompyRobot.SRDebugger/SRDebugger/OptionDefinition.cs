using System;
using System.Runtime.CompilerServices;
using SRF.Helpers;

namespace SRDebugger
{
	public sealed class OptionDefinition
	{
		public string Name
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

		public string Category
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

		public int SortPriority
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

		public bool IsMethod => false;

		public bool IsProperty => false;

		public MethodReference Method
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

		public PropertyReference Property
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

		private OptionDefinition(string name, string category, int sortPriority)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, MethodReference method)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property)
		{
		}

		public static OptionDefinition FromMethod(string name, Action callback, string category = "Default", int sortPriority = 0)
		{
			return null;
		}

		public static OptionDefinition Create<T>(string name, Func<T> getter, Action<T> setter = null, string category = "Default", int sortPriority = 0)
		{
			return null;
		}
	}
}
