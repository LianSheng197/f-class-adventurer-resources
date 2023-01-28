using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class Svd : Svd<double>
	{
		public override int Rank => 0;

		public override double L2Norm => 0.0;

		public override double ConditionNumber => 0.0;

		public override double Determinant => 0.0;

		protected Svd(Vector<double> s, Matrix<double> u, Matrix<double> vt, bool vectorsComputed)
		{
			((Svd<>)(object)this)._002Ector((Vector<T>)null, (Matrix<T>)null, (Matrix<T>)null, vectorsComputed: false);
		}
	}
}
