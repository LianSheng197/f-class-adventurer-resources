using System;
using System.Collections.Generic;
using System.Globalization;

namespace MathNet.Numerics
{
	internal static class GlobalizationHelper
	{
		internal static CultureInfo GetCultureInfo(this IFormatProvider formatProvider)
		{
			return null;
		}

		internal static NumberFormatInfo GetNumberFormatInfo(this IFormatProvider formatProvider)
		{
			return null;
		}

		internal static TextInfo GetTextInfo(this IFormatProvider formatProvider)
		{
			return null;
		}

		internal static void Tokenize(LinkedListNode<string> node, string[] keywords, int skip)
		{
		}

		internal static double ParseDouble(ref LinkedListNode<string> token, CultureInfo culture)
		{
			return 0.0;
		}

		internal static float ParseSingle(ref LinkedListNode<string> token, CultureInfo culture)
		{
			return 0f;
		}
	}
}
