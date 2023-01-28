using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ServiceAttribute : PreserveAttribute
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

		public ServiceAttribute(Type serviceType)
		{
		}
	}
}
