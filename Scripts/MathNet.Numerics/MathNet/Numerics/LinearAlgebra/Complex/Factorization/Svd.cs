using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class Svd : Svd<System.Numerics.Complex>
	{
		public override int Rank => 0;

		public override double L2Norm => 0.0;

		public override System.Numerics.Complex ConditionNumber => default(System.Numerics.Complex);

		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		protected Svd(Vector<System.Numerics.Complex> s, Matrix<System.Numerics.Complex> u, Matrix<System.Numerics.Complex> vt, bool vectorsComputed)
		{
			((Svd<>)(object)this)._002Ector((Vector<T>)null, (Matrix<T>)null, (Matrix<T>)null, vectorsComputed: false);
		}
	}
}
