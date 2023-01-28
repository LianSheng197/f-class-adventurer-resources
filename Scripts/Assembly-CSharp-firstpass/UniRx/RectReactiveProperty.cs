using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class RectReactiveProperty : ReactiveProperty<Rect>
	{
		protected override IEqualityComparer<Rect> EqualityComparer => null;

		public RectReactiveProperty()
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}

		public RectReactiveProperty(Rect initialValue)
		{
			((ReactiveProperty<>)(object)this)._002Ector();
		}
	}
}
