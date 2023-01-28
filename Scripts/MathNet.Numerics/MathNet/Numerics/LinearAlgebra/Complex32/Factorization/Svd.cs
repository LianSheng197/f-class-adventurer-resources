using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class Svd : Svd<MathNet.Numerics.Complex32>
	{
		public override int Rank => 0;

		public override double L2Norm => 0.0;

		public override MathNet.Numerics.Complex32 ConditionNumber => default(MathNet.Numerics.Complex32);

		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		protected Svd(Vector<MathNet.Numerics.Complex32> s, Matrix<MathNet.Numerics.Complex32> u, Matrix<MathNet.Numerics.Complex32> vt, bool vectorsComputed)
		{
			((Svd<>)(object)this)._002Ector((Vector<T>)null, (Matrix<T>)null, (Matrix<T>)null, vectorsComputed: false);
		}
	}
}
