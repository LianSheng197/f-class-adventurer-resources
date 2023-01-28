using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class BoundsReactiveProperty : ReactiveProperty<Bounds>
	{
		protected override IEqualityComparer<Bounds> EqualityComparer => null;

		public BoundsReactiveProperty()
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}

		public BoundsReactiveProperty(Bounds initialValue)
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}
	}
}
