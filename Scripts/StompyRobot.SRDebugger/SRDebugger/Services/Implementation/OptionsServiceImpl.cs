using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IOptionsService))]
	public sealed class OptionsServiceImpl : IOptionsService
	{
		private class OptionContainerEventHandler : IDisposable
		{
			private readonly OptionsServiceImpl _service;

			private readonly IOptionContainer _container;

			public OptionContainerEventHandler(OptionsServiceImpl service, IOptionContainer container)
			{
			}

			private void ContainerOnOptionAdded(OptionDefinition obj)
			{
			}

			private void ContainerOnOptionRemoved(OptionDefinition obj)
			{
			}

			public void Dispose()
			{
			}
		}

		private class ReflectionOptionContainer : IOptionContainer
		{
			private List<OptionDefinition> _options;

			private readonly object _target;

			public bool IsDynamic => false;

			private List<OptionDefinition> Options => null;

			public event Action<OptionDefinition> OptionAdded
			{
				add
				{
				}
				remove
				{
				}
			}

			public event Action<OptionDefinition> OptionRemoved
			{
				add
				{
				}
				remove
				{
				}
			}

			public IEnumerable<OptionDefinition> GetOptions()
			{
				return null;
			}

			public ReflectionOptionContainer(object target)
			{
			}

			protected bool Equals(ReflectionOptionContainer other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private readonly Dictionary<IOptionContainer, List<OptionDefinition>> _optionContainerLookup;

		private readonly Dictionary<IOptionContainer, OptionContainerEventHandler> _optionContainerEventHandlerLookup;

		private readonly List<OptionDefinition> _options;

		private readonly IList<OptionDefinition> _optionsReadonly;

		public ICollection<OptionDefinition> Options => null;

		public event EventHandler OptionsUpdated
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

		private void OptionsContainerOnOptionAdded(IOptionContainer container, OptionDefinition optionDefinition)
		{
		}

		private void OptionsContainerOnOptionRemoved(IOptionContainer container, OptionDefinition optionDefinition)
		{
		}

		public void Scan(object obj)
		{
		}

		public void AddContainer(object obj)
		{
		}

		public void AddContainer(IOptionContainer optionContainer)
		{
		}

		public void RemoveContainer(object obj)
		{
		}

		public void RemoveContainer(IOptionContainer optionContainer)
		{
		}

		private void OnOptionsUpdated()
		{
		}
	}
}
