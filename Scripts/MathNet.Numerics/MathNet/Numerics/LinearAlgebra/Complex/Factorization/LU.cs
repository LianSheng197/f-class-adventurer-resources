using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class LU : LU<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		protected LU(Matrix<System.Numerics.Complex> factors, int[] pivots)
		{
			((LU<>)(object)this)._002Ector((Matrix<T>)null, (int[])null);
		}
	}
}
