using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class Vector4ReactiveProperty : ReactiveProperty<Vector4>
	{
		protected override IEqualityComparer<Vector4> EqualityComparer => null;

		public Vector4ReactiveProperty()
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}

		public Vector4ReactiveProperty(Vector4 initialValue)
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}
	}
}
