using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class Vector3ReactiveProperty : ReactiveProperty<Vector3>
	{
		protected override IEqualityComparer<Vector3> EqualityComparer => null;

		public Vector3ReactiveProperty()
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}

		public Vector3ReactiveProperty(Vector3 initialValue)
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}
	}
}
