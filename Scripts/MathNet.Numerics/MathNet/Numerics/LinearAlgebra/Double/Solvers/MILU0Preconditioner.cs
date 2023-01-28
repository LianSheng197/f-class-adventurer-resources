using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class MILU0Preconditioner : IPreconditioner<double>
	{
		private double[] _alu;

		private int[] _jlu;

		private int[] _diag;

		public bool UseModified
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

		public bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MILU0Preconditioner(bool modified = true)
		{
		}

		public void Initialize(Matrix<double> matrix)
		{
		}

		public void Approximate(Vector<double> input, Vector<double> result)
		{
		}

		private int Compute(int n, double[] a, int[] ja, int[] ia, double[] alu, int[] jlu, int[] ju, bool modified)
		{
			return 0;
		}
	}
}
