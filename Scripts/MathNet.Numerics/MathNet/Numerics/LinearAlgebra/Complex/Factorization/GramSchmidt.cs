using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class GramSchmidt : GramSchmidt<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		public override bool IsFullRank => false;

		protected GramSchmidt(Matrix<System.Numerics.Complex> q, Matrix<System.Numerics.Complex> rFull)
		{
			((GramSchmidt<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null);
		}
	}
}
