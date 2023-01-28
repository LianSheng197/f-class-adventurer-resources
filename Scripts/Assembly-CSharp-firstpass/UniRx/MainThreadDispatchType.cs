using System;

namespace UniRx
{
	public enum MainThreadDispatchType
	{
		Update = 0,
		FixedUpdate = 1,
		EndOfFrame = 2,
		GameObjectUpdate = 3,
		LateUpdate = 4,
		[Obsolete]
		AfterUpdate = 5
	}
}
