using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class Cholesky : Cholesky<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		public override System.Numerics.Complex DeterminantLn => default(System.Numerics.Complex);

		protected Cholesky(Matrix<System.Numerics.Complex> factor)
		{
			((Cholesky<>)(object)this)._002Ector((Matrix<T>)null);
		}
	}
}
