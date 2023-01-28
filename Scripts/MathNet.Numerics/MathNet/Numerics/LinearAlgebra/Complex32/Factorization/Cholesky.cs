using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class Cholesky : Cholesky<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		public override MathNet.Numerics.Complex32 DeterminantLn => default(MathNet.Numerics.Complex32);

		protected Cholesky(Matrix<MathNet.Numerics.Complex32> factor)
		{
			((Cholesky<>)(object)this)._002Ector((Matrix<T>)null);
		}
	}
}
