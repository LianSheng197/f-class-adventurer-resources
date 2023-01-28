using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal abstract class QR : QR<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Determinant => default(System.Numerics.Complex);

		public override bool IsFullRank => false;

		protected QR(Matrix<System.Numerics.Complex> q, Matrix<System.Numerics.Complex> rFull, QRMethod method)
		{
			((QR<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null, default(QRMethod));
		}
	}
}
