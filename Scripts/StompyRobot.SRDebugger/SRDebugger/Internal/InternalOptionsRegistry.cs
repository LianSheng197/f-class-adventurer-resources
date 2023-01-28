using System;
using System.Collections.Generic;
using SRF.Service;

namespace SRDebugger.Internal
{
	[Service(typeof(InternalOptionsRegistry))]
	public sealed class InternalOptionsRegistry
	{
		private List<object> _registeredContainers;

		private Action<object> _handler;

		public void AddOptionContainer(object obj)
		{
		}

		public void SetHandler(Action<object> action)
		{
		}
	}
}
