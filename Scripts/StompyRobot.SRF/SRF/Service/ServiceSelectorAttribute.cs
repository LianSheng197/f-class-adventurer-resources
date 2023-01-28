using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : PreserveAttribute
	{
		public Type ServiceType
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

		public ServiceSelectorAttribute(Type serviceType)
		{
		}
	}
}
