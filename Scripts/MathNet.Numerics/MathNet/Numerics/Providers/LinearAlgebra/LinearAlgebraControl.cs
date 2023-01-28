using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Providers.LinearAlgebra
{
	public static class LinearAlgebraControl
	{
		private const string EnvVarLAProvider = "MathNetNumericsLAProvider";

		private static ILinearAlgebraProvider _linearAlgebraProvider;

		private static readonly object StaticLock;

		private const string MklTypeName = "MathNet.Numerics.Providers.MKL.LinearAlgebra.MklLinearAlgebraControl, MathNet.Numerics.Providers.MKL";

		private static readonly ProviderProbe<ILinearAlgebraProvider> MklProbe;

		private const string OpenBlasTypeName = "MathNet.Numerics.Providers.OpenBLAS.LinearAlgebra.OpenBlasLinearAlgebraControl, MathNet.Numerics.Providers.OpenBLAS";

		private static readonly ProviderProbe<ILinearAlgebraProvider> OpenBlasProbe;

		private const string CudaTypeName = "MathNet.Numerics.Providers.CUDA.LinearAlgebra.CudaLinearAlgebraControl, MathNet.Numerics.Providers.CUDA";

		private static readonly ProviderProbe<ILinearAlgebraProvider> CudaProbe;

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

		public static ILinearAlgebraProvider Provider
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

		public static void UseNativeCUDA()
		{
		}

		public static bool TryUseNativeCUDA()
		{
			return false;
		}

		public static void UseNativeOpenBLAS()
		{
		}

		public static bool TryUseNativeOpenBLAS()
		{
			return false;
		}

		public static bool TryUseNative()
		{
			return false;
		}

		public static bool TryUse(ILinearAlgebraProvider provider)
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
