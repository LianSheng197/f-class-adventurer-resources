using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserEvd : Evd
	{
		public static UserEvd Create(Matrix<float> matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private UserEvd(Matrix<float> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<float> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		private static void SymmetricTridiagonalize(Matrix<float> eigenVectors, float[] d, float[] e, int order)
		{
		}

		private static void SymmetricDiagonalize(Matrix<float> eigenVectors, float[] d, float[] e, int order)
		{
		}

		private static void NonsymmetricReduceToHessenberg(Matrix<float> eigenVectors, float[,] matrixH, int order)
		{
		}

		private static void NonsymmetricReduceHessenberToRealSchur(Matrix<float> eigenVectors, float[,] matrixH, float[] d, float[] e, int order)
		{
		}

		private static MathNet.Numerics.Complex32 Cdiv(float xreal, float ximag, float yreal, float yimag)
		{
			return default(MathNet.Numerics.Complex32);
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}
	}
}
