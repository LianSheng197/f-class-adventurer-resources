using System.Numerics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class MILU0Preconditioner : IPreconditioner<System.Numerics.Complex>
	{
		private System.Numerics.Complex[] _alu;

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

		public void Initialize(Matrix<System.Numerics.Complex> matrix)
		{
		}

		public void Approximate(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}

		private int Compute(int n, System.Numerics.Complex[] a, int[] ja, int[] ia, System.Numerics.Complex[] alu, int[] jlu, int[] ju, bool modified)
		{
			return 0;
		}
	}
}
