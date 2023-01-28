using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserEvd : Evd
	{
		public static UserEvd Create(Matrix<MathNet.Numerics.Complex32> matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private UserEvd(Matrix<MathNet.Numerics.Complex32> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<MathNet.Numerics.Complex32> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		private static void SymmetricTridiagonalize(MathNet.Numerics.Complex32[,] matrixA, float[] d, float[] e, MathNet.Numerics.Complex32[] tau, int order)
		{
		}

		private static void SymmetricDiagonalize(Matrix<MathNet.Numerics.Complex32> eigenVectors, float[] d, float[] e, int order)
		{
		}

		private static void SymmetricUntridiagonalize(Matrix<MathNet.Numerics.Complex32> eigenVectors, MathNet.Numerics.Complex32[,] matrixA, MathNet.Numerics.Complex32[] tau, int order)
		{
		}

		private static void NonsymmetricReduceToHessenberg(Matrix<MathNet.Numerics.Complex32> eigenVectors, MathNet.Numerics.Complex32[,] matrixH, int order)
		{
		}

		private static void NonsymmetricReduceHessenberToRealSchur(Matrix<MathNet.Numerics.Complex32> eigenVectors, Vector<System.Numerics.Complex> eigenValues, MathNet.Numerics.Complex32[,] matrixH, int order)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
