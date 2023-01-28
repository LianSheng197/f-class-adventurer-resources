using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class GramSchmidt : GramSchmidt<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		public override bool IsFullRank => false;

		protected GramSchmidt(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull)
		{
			((GramSchmidt<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null);
		}
	}
}
