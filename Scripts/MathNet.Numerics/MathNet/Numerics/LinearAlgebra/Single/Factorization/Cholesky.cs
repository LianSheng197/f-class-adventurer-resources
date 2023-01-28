using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class Cholesky : Cholesky<float>
	{
		public override float Determinant => 0f;

		public override float DeterminantLn => 0f;

		protected Cholesky(Matrix<float> factor)
		{
			((Cholesky<>)(object)this)._002Ector((Matrix<T>)null);
		}
	}
}
