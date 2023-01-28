using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class LU : LU<double>
	{
		public override double Determinant => 0.0;

		protected LU(Matrix<double> factors, int[] pivots)
		{
			((LU<>)(object)this)._002Ector((Matrix<T>)null, (int[])null);
		}
	}
}
