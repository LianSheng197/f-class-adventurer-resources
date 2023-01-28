using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Statistics.Mcmc
{
	public static class MCMCDiagnostics
	{
		public static double ACF<T>(IEnumerable<T> series, int lag, Func<T, double> f)
		{
			return 0.0;
		}

		public static double EffectiveSize<T>(IEnumerable<T> series, Func<T, double> f)
		{
			return 0.0;
		}
	}
}
