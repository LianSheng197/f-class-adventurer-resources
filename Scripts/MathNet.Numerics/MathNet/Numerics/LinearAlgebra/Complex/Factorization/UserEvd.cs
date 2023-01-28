using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class UserEvd : Evd
	{
		public static UserEvd Create(Matrix<System.Numerics.Complex> matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private UserEvd(Matrix<System.Numerics.Complex> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<System.Numerics.Complex> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		private static void SymmetricTridiagonalize(System.Numerics.Complex[,] matrixA, double[] d, double[] e, System.Numerics.Complex[] tau, int order)
		{
		}

		private static void SymmetricDiagonalize(Matrix<System.Numerics.Complex> eigenVectors, double[] d, double[] e, int order)
		{
		}

		private static void SymmetricUntridiagonalize(Matrix<System.Numerics.Complex> eigenVectors, System.Numerics.Complex[,] matrixA, System.Numerics.Complex[] tau, int order)
		{
		}

		private static void NonsymmetricReduceToHessenberg(Matrix<System.Numerics.Complex> eigenVectors, System.Numerics.Complex[,] matrixH, int order)
		{
		}

		private static void NonsymmetricReduceHessenberToRealSchur(Matrix<System.Numerics.Complex> eigenVectors, Vector<System.Numerics.Complex> eigenValues, System.Numerics.Complex[,] matrixH, int order)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
