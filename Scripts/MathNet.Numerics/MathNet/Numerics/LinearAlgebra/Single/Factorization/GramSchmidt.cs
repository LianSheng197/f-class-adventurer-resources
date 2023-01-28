using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class GramSchmidt : GramSchmidt<float>
	{
		public override float Determinant => 0f;

		public override bool IsFullRank => false;

		protected GramSchmidt(Matrix<float> q, Matrix<float> rFull)
		{
			((GramSchmidt<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null);
		}
	}
}
