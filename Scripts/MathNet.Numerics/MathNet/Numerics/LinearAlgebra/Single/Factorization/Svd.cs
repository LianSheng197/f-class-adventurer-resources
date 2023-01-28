using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class Svd : Svd<float>
	{
		public override int Rank => 0;

		public override double L2Norm => 0.0;

		public override float ConditionNumber => 0f;

		public override float Determinant => 0f;

		protected Svd(Vector<float> s, Matrix<float> u, Matrix<float> vt, bool vectorsComputed)
		{
			((Svd<>)(object)this)._002Ector((Vector<T>)null, (Matrix<T>)null, (Matrix<T>)null, vectorsComputed: false);
		}
	}
}
