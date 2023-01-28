using System;
using System.Collections.Generic;

namespace MathNet.Numerics.LinearRegression
{
	internal static class Util
	{
		public static (TU[], TV[]) UnpackSinglePass<TU, TV>(this IEnumerable<Tuple<TU, TV>> samples)
		{
			return default((TU[], TV[]));
		}

		public static (TU[], TV[]) UnpackSinglePass<TU, TV>(this IEnumerable<(TU, TV)> samples)
		{
			return default((TU[], TV[]));
		}
	}
}
