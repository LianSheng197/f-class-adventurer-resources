using System;
using System.Reflection;

namespace SRF.Helpers
{
	public sealed class MethodReference
	{
		private readonly Func<object[], object> _method;

		public MethodReference(object target, MethodInfo method)
		{
		}

		public MethodReference(Func<object[], object> method)
		{
		}

		public object Invoke(object[] parameters)
		{
			return null;
		}

		public static implicit operator MethodReference(Action action)
		{
			return null;
		}
	}
}
