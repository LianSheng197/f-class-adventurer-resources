using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Providers.SparseSolver
{
	public static class SparseSolverControl
	{
		private const string EnvVarSSProvider = "MathNetNumericsSSProvider";

		private static ISparseSolverProvider _sparseSolverProvider;

		private static readonly object StaticLock;

		private const string MklTypeName = "MathNet.Numerics.Providers.MKL.SparseSolver.MklSparseSolverControl, MathNet.Numerics.Providers.MKL";

		private static readonly ProviderProbe<ISparseSolverProvider> MklProbe;

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

		public static ISparseSolverProvider Provider
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

		public static bool TryUse(ISparseSolverProvider provider)
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
