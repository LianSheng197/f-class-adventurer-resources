using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class MILU0Preconditioner : IPreconditioner<float>
	{
		private float[] _alu;

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

		public void Initialize(Matrix<float> matrix)
		{
		}

		public void Approximate(Vector<float> input, Vector<float> result)
		{
		}

		private int Compute(int n, float[] a, int[] ja, int[] ia, float[] alu, int[] jlu, int[] ju, bool modified)
		{
			return 0;
		}
	}
}
