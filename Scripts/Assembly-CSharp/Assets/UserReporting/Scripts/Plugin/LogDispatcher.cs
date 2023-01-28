using System;
using System.Collections.Generic;

namespace Assets.UserReporting.Scripts.Plugin
{
	public static class LogDispatcher
	{
		private static List<WeakReference> listeners;

		static LogDispatcher()
		{
		}

		public static void Register(ILogListener logListener)
		{
		}
	}
}
