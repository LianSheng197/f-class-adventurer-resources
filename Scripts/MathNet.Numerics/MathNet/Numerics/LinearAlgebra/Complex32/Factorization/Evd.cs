using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class Evd : Evd<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		public override int Rank => 0;

		public override bool IsFullRank => false;

		protected Evd(Matrix<MathNet.Numerics.Complex32> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<MathNet.Numerics.Complex32> blockDiagonal, bool isSymmetric)
		{
			((Evd<>)(object)this)._002Ector((Matrix<T>)null, (Vector<System.Numerics.Complex>)null, (Matrix<T>)null, isSymmetric: false);
		}
	}
}
