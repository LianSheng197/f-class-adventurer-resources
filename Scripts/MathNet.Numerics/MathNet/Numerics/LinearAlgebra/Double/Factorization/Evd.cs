using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class Evd : Evd<double>
	{
		public override double Determinant => 0.0;

		public override int Rank => 0;

		public override bool IsFullRank => false;

		protected Evd(Matrix<double> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<double> blockDiagonal, bool isSymmetric)
		{
			((Evd<>)(object)this)._002Ector((Matrix<T>)null, (Vector<System.Numerics.Complex>)null, (Matrix<T>)null, isSymmetric: false);
		}
	}
}
