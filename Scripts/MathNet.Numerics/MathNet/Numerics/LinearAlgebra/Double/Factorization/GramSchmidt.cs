using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class GramSchmidt : GramSchmidt<double>
	{
		public override double Determinant => 0.0;

		public override bool IsFullRank => false;

		protected GramSchmidt(Matrix<double> q, Matrix<double> rFull)
		{
			((GramSchmidt<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null);
		}
	}
}
