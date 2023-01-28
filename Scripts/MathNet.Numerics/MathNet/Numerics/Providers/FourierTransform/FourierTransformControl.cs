using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Providers.FourierTransform
{
	public static class FourierTransformControl
	{
		private const string EnvVarFFTProvider = "MathNetNumericsFFTProvider";

		private static IFourierTransformProvider _fourierTransformProvider;

		private static readonly object StaticLock;

		private const string MklTypeName = "MathNet.Numerics.Providers.MKL.FourierTransform.MklFourierTransformControl, MathNet.Numerics.Providers.MKL";

		private static readonly ProviderProbe<IFourierTransformProvider> MklProbe;

		public static string HintPath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static IFourierTransformProvider Provider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static void UseManaged()
		{
		}

		public static void UseNativeMKL()
		{
		}

		public static bool TryUseNativeMKL()
		{
			return false;
		}

		public static bool TryUseNative()
		{
			return false;
		}

		public static bool TryUse(IFourierTransformProvider provider)
		{
			return false;
		}

		public static void UseBest()
		{
		}

		public static void UseDefault()
		{
		}

		public static void FreeResources()
		{
		}
	}
}
