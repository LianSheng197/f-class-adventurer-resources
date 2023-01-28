using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MathNet.Numerics
{
	public static class Control
	{
		private static int _maxDegreeOfParallelism;

		private static int _parallelizeOrder;

		private static int _parallelizeElements;

		private static string _nativeProviderHintPath;

		public static bool CheckDistributionParameters
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool ThreadSafeRandomNumberGenerators
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static string NativeProviderPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int MaxDegreeOfParallelism
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static TaskScheduler TaskScheduler
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

		internal static int ParallelizeOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal static int ParallelizeElements
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		static Control()
		{
		}

		public static void ConfigureAuto()
		{
		}

		public static void UseManaged()
		{
		}

		public static void UseDefaultProviders()
		{
		}

		public static void UseBestProviders()
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

		public static void FreeResources()
		{
		}

		public static void UseSingleThread()
		{
		}

		public static void UseMultiThreading()
		{
		}

		public static string Describe()
		{
			return null;
		}
	}
}
