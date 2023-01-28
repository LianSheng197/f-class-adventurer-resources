using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal abstract class QR : QR<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Determinant => default(MathNet.Numerics.Complex32);

		public override bool IsFullRank => false;

		protected QR(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull, QRMethod method)
		{
			((QR<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null, default(QRMethod));
		}
	}
}
