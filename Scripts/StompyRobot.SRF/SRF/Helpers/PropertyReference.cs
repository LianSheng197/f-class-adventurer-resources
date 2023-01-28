using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SRF.Helpers
{
	public sealed class PropertyReference
	{
		[CanBeNull]
		private readonly PropertyInfo _property;

		[CanBeNull]
		private readonly object _target;

		[CanBeNull]
		private readonly Attribute[] _attributes;

		[CanBeNull]
		private readonly Func<object> _getter;

		[CanBeNull]
		private readonly Action<object> _setter;

		[CanBeNull]
		private List<PropertyValueChangedHandler> _valueChangedListeners;

		public Type PropertyType
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

		public bool CanRead => false;

		public bool CanWrite => false;

		public event PropertyValueChangedHandler ValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public static PropertyReference FromLambda<T>(Func<T> getter, Action<T> setter = null, params Attribute[] attributes)
		{
			return null;
		}

		public PropertyReference(object target, PropertyInfo property)
		{
		}

		public PropertyReference(Type type, Func<object> getter = null, Action<object> setter = null, Attribute[] attributes = null)
		{
		}

		public void NotifyValueChanged()
		{
		}

		public object GetValue()
		{
			return null;
		}

		public void SetValue(object value)
		{
		}

		public T GetAttribute<T>() where T : Attribute
		{
			return null;
		}

		private void OnTargetPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}
	}
}
