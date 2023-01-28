using System;
using System.Runtime.CompilerServices;
using SRF.Helpers;

namespace SRDebugger.UI.Controls
{
	public abstract class DataBoundControl : OptionsControlBase
	{
		private bool _hasStarted;

		private bool _isReadOnly;

		private object _prevValue;

		private PropertyReference _prop;

		public PropertyReference Property => null;

		public bool IsReadOnly => false;

		public string PropertyName
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

		public void Bind(string propertyName, PropertyReference prop)
		{
		}

		private void OnValueChanged(PropertyReference property)
		{
		}

		protected void UpdateValue(object newValue)
		{
		}

		public override void Refresh()
		{
		}

		protected virtual void OnBind(string propertyName, Type t)
		{
		}

		protected abstract void OnValueUpdated(object newValue);

		public abstract bool CanBind(Type type, bool isReadOnly);

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
