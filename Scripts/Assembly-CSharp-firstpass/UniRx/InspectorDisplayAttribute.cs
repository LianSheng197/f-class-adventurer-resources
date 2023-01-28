using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class InspectorDisplayAttribute : PropertyAttribute
	{
		public string FieldName
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

		public bool NotifyPropertyChanged
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InspectorDisplayAttribute(string fieldName = "value", bool notifyPropertyChanged = true)
		{
		}
	}
}
