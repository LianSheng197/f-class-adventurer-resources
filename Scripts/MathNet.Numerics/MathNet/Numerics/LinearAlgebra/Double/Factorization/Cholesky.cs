using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class Cholesky : Cholesky<double>
	{
		public override double Determinant => 0.0;

		public override double DeterminantLn => 0.0;

		protected Cholesky(Matrix<double> factor)
		{
			((Cholesky<>)(object)this)._002Ector((Matrix<T>)null);
		}
	}
}
