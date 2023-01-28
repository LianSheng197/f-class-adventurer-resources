using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class LU : LU<float>
	{
		public override float Determinant => 0f;

		protected LU(Matrix<float> factors, int[] pivots)
		{
			((LU<>)(object)this)._002Ector((Matrix<T>)null, (int[])null);
		}
	}
}
