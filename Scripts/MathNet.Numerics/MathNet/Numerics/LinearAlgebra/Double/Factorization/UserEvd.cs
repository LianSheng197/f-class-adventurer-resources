using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserEvd : Evd
	{
		public static UserEvd Create(Matrix<double> matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private UserEvd(Matrix<double> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<double> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		private static void SymmetricTridiagonalize(Matrix<double> eigenVectors, double[] d, double[] e, int order)
		{
		}

		private static void SymmetricDiagonalize(Matrix<double> eigenVectors, double[] d, double[] e, int order)
		{
		}

		private static void NonsymmetricReduceToHessenberg(Matrix<double> eigenVectors, double[,] matrixH, int order)
		{
		}

		private static void NonsymmetricReduceHessenberToRealSchur(Matrix<double> eigenVectors, double[,] matrixH, double[] d, double[] e, int order)
		{
		}

		private static System.Numerics.Complex Cdiv(double xreal, double ximag, double yreal, double yimag)
		{
			return default(System.Numerics.Complex);
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}
	}
}
