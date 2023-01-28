using System;
using System.Threading.Tasks;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Threading.Internal
{
	internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent
	{
		private bool Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002EIsRunningOnUnityThread => false;

		public static Task PostAsync(Action action)
		{
			return null;
		}

		public static Task PostAsync(Action<object> action, object state)
		{
			return null;
		}

		public static Task<T> PostAsync<T>(Func<T> action)
		{
			return null;
		}

		public static Task<T> PostAsync<T>(Func<object, T> action, object state)
		{
			return null;
		}

		public static void Send(Action action)
		{
		}

		public static void Send(Action<object> action, object state)
		{
		}

		public static T Send<T>(Func<T> action)
		{
			return default(T);
		}

		public static T Send<T>(Func<object, T> action, object state)
		{
			return default(T);
		}

		private Task Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002EPostAsync(Action action)
		{
			return null;
		}

		private Task Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002EPostAsync(Action<object> action, object state)
		{
			return null;
		}

		private Task<T> Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002EPostAsync<T>(Func<T> action)
		{
			return null;
		}

		private Task<T> Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002EPostAsync<T>(Func<object, T> action, object state)
		{
			return null;
		}

		private void Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002ESend(Action action)
		{
		}

		private void Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002ESend(Action<object> action, object state)
		{
		}

		private T Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002ESend<T>(Func<T> action)
		{
			return default(T);
		}

		private T Unity_002EServices_002ECore_002EThreading_002EInternal_002EIUnityThreadUtils_002ESend<T>(Func<object, T> action, object state)
		{
			return default(T);
		}
	}
}
