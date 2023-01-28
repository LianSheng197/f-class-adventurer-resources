using UnityEngine;

namespace I2.Loc
{
	public class LocalizeTarget_NGUI_Sprite : LocalizeTarget<UISprite>
	{
		static LocalizeTarget_NGUI_Sprite()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = null;
			secondaryTerm = null;
		}

		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		public LocalizeTarget_NGUI_Sprite()
		{
			((LocalizeTarget<>)(object)this)._002Ector();
		}
	}
}
