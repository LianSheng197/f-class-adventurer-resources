using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class LU : LU<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		protected LU(Matrix<MathNet.Numerics.Complex32> factors, int[] pivots)
		{
			((LU<>)(object)this)._002Ector((Matrix<T>)null, (int[])null);
		}
	}
}
