using System;
using System.Globalization;

namespace Unity.Services.Analytics.Internal
{
	internal static class Locale
	{
		internal static string CurrentLanguageCode()
		{
			return null;
		}

		public static string AnalyticsRegionLanguageCode()
		{
			return null;
		}

		[Obsolete("The 'language-regionSettingsCountry' code used by Analytics is non-standard, so this method may throw exceptions when used on systems with non-ISO language/region combinations. Prefer using AnalyticsRegionLanguageCode instead.")]
		public static CultureInfo CurrentCulture()
		{
			return null;
		}

		[Obsolete("The 'language-regionSettingsCountry' code used by Analytics is non-standard, so this method may throw exceptions when used on systems with non-ISO language/region combinations. Prefer using AnalyticsRegionLanguageCode instead.")]
		public static CultureInfo SystemCulture()
		{
			return null;
		}
	}
}
