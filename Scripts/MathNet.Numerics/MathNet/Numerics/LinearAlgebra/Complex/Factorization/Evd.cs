using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class Evd : Evd<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		public override int Rank => 0;

		public override bool IsFullRank => false;

		protected Evd(Matrix<System.Numerics.Complex> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<System.Numerics.Complex> blockDiagonal, bool isSymmetric)
		{
			((Evd<>)(object)this)._002Ector((Matrix<T>)null, (Vector<System.Numerics.Complex>)null, (Matrix<T>)null, isSymmetric: false);
		}
	}
}
