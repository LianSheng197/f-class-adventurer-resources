using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SRDebugger
{
	public sealed class DynamicOptionContainer : IOptionContainer
	{
		private readonly List<OptionDefinition> _options;

		private readonly IList<OptionDefinition> _optionsReadOnly;

		public IList<OptionDefinition> Options => null;

		public bool IsDynamic => false;

		public event Action<OptionDefinition> OptionAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OptionDefinition> OptionRemoved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddOption(OptionDefinition option)
		{
		}

		public bool RemoveOption(OptionDefinition option)
		{
			return false;
		}

		private IEnumerable<OptionDefinition> SRDebugger_002EIOptionContainer_002EGetOptions()
		{
			return null;
		}
	}
}
