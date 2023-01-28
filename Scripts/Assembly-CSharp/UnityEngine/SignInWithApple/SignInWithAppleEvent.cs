using System;
using UnityEngine.Events;

namespace UnityEngine.SignInWithApple
{
	[Serializable]
	public class SignInWithAppleEvent : UnityEvent<SignInWithApple.CallbackArgs>
	{
		public SignInWithAppleEvent()
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}
	}
}
