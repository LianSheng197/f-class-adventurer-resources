using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Providers.SparseSolver
{
	public sealed class ManagedSparseSolverProvider : ISparseSolverProvider, ISparseSolverProvider<double>, ISparseSolverProvider<float>, ISparseSolverProvider<Complex>, ISparseSolverProvider<Complex32>
	{
		public static ManagedSparseSolverProvider Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsAvailable()
		{
			return false;
		}

		public void InitializeVerify()
		{
		}

		public void FreeResources()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public DssStatus Solve(DssMatrixStructure matrixStructure, DssMatrixType matrixType, DssSystemType systemType, int rowCount, int columnCount, int nonZerosCount, int[] rowPointers, int[] columnIndices, float[] values, int nRhs, float[] rhs, float[] solution)
		{
			return default(DssStatus);
		}

		public DssStatus Solve(DssMatrixStructure matrixStructure, DssMatrixType matrixType, DssSystemType systemType, int rowCount, int columnCount, int nonZerosCount, int[] rowPointers, int[] columnIndices, double[] values, int nRhs, double[] rhs, double[] solution)
		{
			return default(DssStatus);
		}

		public DssStatus Solve(DssMatrixStructure matrixStructure, DssMatrixType matrixType, DssSystemType systemType, int rowCount, int columnCount, int nonZerosCount, int[] rowPointers, int[] columnIndices, Complex32[] values, int nRhs, Complex32[] rhs, Complex32[] solution)
		{
			return default(DssStatus);
		}

		public DssStatus Solve(DssMatrixStructure matrixStructure, DssMatrixType matrixType, DssSystemType systemType, int rowCount, int columnCount, int nonZerosCount, int[] rowPointers, int[] columnIndices, Complex[] values, int nRhs, Complex[] rhs, Complex[] solution)
		{
			return default(DssStatus);
		}
	}
}
