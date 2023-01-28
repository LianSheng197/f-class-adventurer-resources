using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class Vector2ReactiveProperty : ReactiveProperty<Vector2>
	{
		protected override IEqualityComparer<Vector2> EqualityComparer => null;

		public Vector2ReactiveProperty()
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}

		public Vector2ReactiveProperty(Vector2 initialValue)
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}
	}
}
