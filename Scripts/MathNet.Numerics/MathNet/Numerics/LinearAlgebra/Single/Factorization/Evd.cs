using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class Evd : Evd<float>
	{
		public override float Determinant => 0f;

		public override int Rank => 0;

		public override bool IsFullRank => false;

		protected Evd(Matrix<float> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<float> blockDiagonal, bool isSymmetric)
		{
			((Evd<>)(object)this)._002Ector((Matrix<T>)null, (Vector<System.Numerics.Complex>)null, (Matrix<T>)null, isSymmetric: false);
		}
	}
}
