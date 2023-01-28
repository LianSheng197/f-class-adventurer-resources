using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class MILU0Preconditioner : IPreconditioner<MathNet.Numerics.Complex32>
	{
		private MathNet.Numerics.Complex32[] _alu;

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

		public void Initialize(Matrix<MathNet.Numerics.Complex32> matrix)
		{
		}

		public void Approximate(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		private int Compute(int n, MathNet.Numerics.Complex32[] a, int[] ja, int[] ia, MathNet.Numerics.Complex32[] alu, int[] jlu, int[] ju, bool modified)
		{
			return 0;
		}
	}
}
