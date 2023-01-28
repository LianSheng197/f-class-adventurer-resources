using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal abstract class QR : QR<float>
	{
		public override float Determinant => 0f;

		public override bool IsFullRank => false;

		protected QR(Matrix<float> q, Matrix<float> rFull, QRMethod method)
		{
			((QR<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null, default(QRMethod));
		}
	}
}
