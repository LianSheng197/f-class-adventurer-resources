using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal abstract class QR : QR<double>
	{
		public override double Determinant => 0.0;

		public override bool IsFullRank => false;

		protected QR(Matrix<double> q, Matrix<double> rFull, QRMethod method)
		{
			((QR<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null, default(QRMethod));
		}
	}
}
