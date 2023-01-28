using System;

namespace I2.Loc
{
	[Serializable]
	public struct LocalizedString
	{
		public string mTerm;

		public bool mRTL_IgnoreArabicFix;

		public int mRTL_MaxLineLength;

		public bool mRTL_ConvertNumbers;

		public bool m_DontLocalizeParameters;

		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		public LocalizedString(LocalizedString str)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
